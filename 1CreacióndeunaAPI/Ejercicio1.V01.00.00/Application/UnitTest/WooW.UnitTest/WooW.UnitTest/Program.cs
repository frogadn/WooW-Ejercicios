﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using ServiceStack.Auth;
using ServiceStack.Messaging;
using ServiceStack.Web;
using WooW;
using WooW.Core;
//using static ServiceStack.Html.Input;
using WooW.Socket;

namespace WooW.UnitTest
{
    internal class Program
    {
        [DllImport(
            "User32.dll",
            CallingConvention = CallingConvention.StdCall,
            SetLastError = true
        )]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow([In] IntPtr hWnd, [In] int nCmdShow);

        static bool bUseConsole = true;

        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 19)
                    throw new Exception($"Error en número de argumentos {args.Length}");

                //if (AppDomain.CurrentDomain.GetData("Argumentos") != null)

                if (args[0] == "Socket")
                {
                    // Minimiza ventana
                    IntPtr handle = Process.GetCurrentProcess().MainWindowHandle;
                    ShowWindow(handle, 6);
                    bUseConsole = false;
                }

                Console.BackgroundColor = ConsoleColor.Black;

                IWoUnitTest unit = null;

                foreach (var ass in AppDomain.CurrentDomain.GetAssemblies())
                {
                    var types = ass.GetTypes()
                        .Where(mytype => mytype.GetInterfaces().Contains(typeof(IWoUnitTest)));
                    if (types.Count() > 0)
                    {
                        unit = (IWoUnitTest)ass.CreateInstance(types.FirstOrDefault().FullName);
                        break;
                    }
                }

                if (unit == null)
                    throw new Exception("No se encontró prueba unitaria");

                unit.Uth = new WoUthHelper()
                {
                    dLog = ConsoleLog,
                    dLogWarning = ConsoleWarningLog,
                    dLogError = ConsoleErrorLog,
                    dLogSuccess = ConsoleSuccessLog
                };

                unit.User = args[4];
                unit.Password = args[5];
                unit.Instance = args[6];
                unit.Year = System.Convert.ToInt32(args[7]);
                unit.Udn = args[8];

                unit.ParamsDecimal = new decimal[5];
                unit.ParamsDecimal[0] = System.Convert.ToDecimal(args[9]);
                unit.ParamsDecimal[1] = System.Convert.ToDecimal(args[10]);
                unit.ParamsDecimal[2] = System.Convert.ToDecimal(args[11]);
                unit.ParamsDecimal[3] = System.Convert.ToDecimal(args[12]);
                unit.ParamsDecimal[4] = System.Convert.ToDecimal(args[13]);

                unit.ParamsString = new string[5];

                unit.ParamsString[0] = args[14].ToString().Replace("|", "");
                unit.ParamsString[1] = args[15].ToString().Replace("|", "");
                unit.ParamsString[2] = args[16].ToString().Replace("|", "");
                unit.ParamsString[3] = args[17].ToString().Replace("|", "");
                unit.ParamsString[4] = args[18].ToString().Replace("|", "");

                var woTarget = new JsonApiClient(args[2]);

                var AuthenticateResponse = woTarget.Post<AuthenticateResponse>(
                    new Authenticate
                    {
                        provider = CredentialsAuthProvider.Name, //= credentials
                        UserName = unit.User,
                        Password = unit.Password,
                        RememberMe = true,
                    }
                );

                woTarget.BearerToken = AuthenticateResponse.BearerToken;
                woTarget.GetHttpClient().DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", AuthenticateResponse.BearerToken);

                var InstanciaUdnResponse = woTarget.Post(
                    new InstanciaUdnAsignar
                    {
                        Instance = unit.Instance,
                        Udn = unit.Udn,
                        Year = unit.Year
                    }
                );

                DateTime now = DateTime.Now;

                bool EjecucionExitosa = true;

                for (int i = 0; i < System.Convert.ToInt32(args[3]); i++)
                {
                    unit.ExecuteNumber = i + 1;
                    if (!unit.Run(woTarget))
                        EjecucionExitosa = false;
                }

                TimeSpan transcurrido = DateTime.Now - now;

                if (System.Convert.ToInt32(args[3]) > 1)
                    ConsoleLog(
                        $"Tiempo de la Prueba Unitaria {transcurrido.Hours:00}:{transcurrido.Minutes:00}:{transcurrido.Seconds:00}, Veces {args[3]}"
                    );
                else
                    ConsoleLog(
                        $"Tiempo de la Prueba Unitaria {transcurrido.Hours:00}:{transcurrido.Minutes:00}:{transcurrido.Seconds:00}"
                    );

                if (EjecucionExitosa)
                    ExitCode(0);
                else
                    ExitCode(1);
            }
            catch (Exception ex)
            {
                ExitCode(2);
                ConsoleCriticalLog(ex.Message);
            }

            System.Threading.Thread.Sleep(1000);
        }

        public static void ExitCode(int Code)
        {
            string sExitCode = $"ExitCode>{Code}";

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(sExitCode);
            if (!bUseConsole)
            {
                SendBySocket($"ExitCode>", Code.ToString());
                SendBySocket($"ConsoleTitle> ", "Código de Prueba Terminada " + Code.ToString());
            }
        }

        public static void ConsoleLog(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            if (!bUseConsole)
                SendBySocket($"Console> ", message);
        }

        public static void ConsoleWarningLog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            if (!bUseConsole)
                SendBySocket($"ConsoleWarning> ", message);
        }

        public static void ConsoleErrorLog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            if (!bUseConsole)
                SendBySocket($"ConsoleError> ", message);
        }

        public static void ConsoleTitleLog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            if (!bUseConsole)
                SendBySocket($"ConsoleTitle> ", message);
        }

        private static void ConsoleCriticalLog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            if (!bUseConsole)
                SendBySocket($"ConsoleCritical> ", message);
        }

        private static void ConsoleSuccessLog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            if (!bUseConsole)
                SendBySocket($"ConsoleSuccess> ", message);
        }

        public static void SendBySocket(string prefix, string message)
        {
            try
            {
                int Max = 4096;

                string[] Lines = (prefix + message).Replace("\r\n", "\n").Split('\n');

                string Send = string.Empty;
                foreach (string Line in Lines)
                {
                    if ((Send + Line).Length > Max)
                    {
                        using (var socket = new WoConnectedSocket("127.0.0.1", 1337)) // Connects to 127.0.0.1 on port 1337
                        {
                            string dataToSend = Send;
                            socket.Send(dataToSend); // Sends some data
                            //var data = socket.Receive(); // Receives some data back (blocks execution)
                            //txtRecivedData.Text = data;
                        }
                        Send = string.Empty;
                    }
                    else
                    {
                        if (Send != string.Empty)
                            Send += "\r\n" + Line;
                        else
                            Send += Line;
                    }
                }

                if (Send != string.Empty)
                {
                    using (var socket = new WoConnectedSocket("127.0.0.1", 1337)) // Connects to 127.0.0.1 on port 1337
                    {
                        string dataToSend = Send;
                        socket.Send(dataToSend); // Sends some data
                        //var data = socket.Receive(); // Receives some data back (blocks execution)
                        //txtRecivedData.Text = data;
                    }
                }
            }
            catch { }
        }
    }
}
