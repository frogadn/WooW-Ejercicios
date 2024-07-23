using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooW.Model
{
    public static class WoConsoleDebug
    {
        public static void IsNull(object obj, string message)
        {
            if (obj == null)
                WriteArgumentNullException(message);
        }

        public static void IsNotNull(object obj, string message)
        {
            if (obj != null)
                WriteArgumentNullException(message);
        }

        public static void IsNullOrEmpty(string obj, string message)
        {
            if (string.IsNullOrEmpty(obj))
                WriteArgumentNullException(message);
        }

        public static void IsNotNullOrWhiteSpace(string obj, string message)
        {
            if (string.IsNullOrWhiteSpace(obj))
                WriteArgumentNullException(message);
        }

        public static void IsTrue(bool condition, string message)
        {
            if (condition)
                WriteArgumentException(message);
        }

        public static void IsFalse(bool condition, string message)
        {
            if (!condition)
                WriteArgumentException(message);
        }

        public static void OutOfRange(int value, int min, int max, string message)
        {
            if (value < min || value > max)
                WriteArgumentOutOfRangeException(message);
        }

        public static void OutOfRange(double value, double min, double max, string message)
        {
            if (value < min || value > max)
                WriteArgumentOutOfRangeException(message);
        }

        public static void OutOfRange(decimal value, decimal min, decimal max, string message)
        {
            if (value < min || value > max)
                WriteArgumentOutOfRangeException(message);
        }

        public static void OutOfRange(float value, float min, float max, string message)
        {
            if (value < min || value > max)
                WriteArgumentOutOfRangeException(message);
        }

        public static void OutOfRange(long value, long min, long max, string message)
        {
            if (value < min || value > max)
                WriteArgumentOutOfRangeException(message);
        }

        public static void OutOfRange(short value, short min, short max, string message)
        {
            if (value < min || value > max)
                WriteArgumentOutOfRangeException(message);
        }

        public static void OutOfRange(byte value, byte min, byte max, string message)
        {
            if (value < min || value > max)
                WriteArgumentOutOfRangeException(message);
        }

        public static void OutOfRange(ushort value, ushort min, ushort max, string message)
        {
            if (value < min || value > max)
                WriteArgumentOutOfRangeException(message);
        }

        public static void OutOfRange(uint value, uint min, uint max, string message)
        {
            if (value < min || value > max)
                WriteArgumentOutOfRangeException(message);
        }

        static void WriteArgumentNullException(string value)
        {
#if DEBUG
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("WoConsole:");
            // Write an entire line to the console with the string.
            Console.ResetColor();
            Console.WriteLine(" " + value);
#endif
        }

        static void WriteArgumentException(string value)
        {
#if DEBUG
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("WoConsole:");
            // Write an entire line to the console with the string.
            Console.ResetColor();
            Console.WriteLine(" " + value);
#endif
        }

        static void WriteArgumentOutOfRangeException(string value)
        {
#if DEBUG
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("WoConsole:");
            // Write an entire line to the console with the string.
            Console.ResetColor();
            Console.WriteLine(" " + value);
#endif
        }

        public static class WoConsoleTrace
        {
            public static void IsNull(object obj, string message)
            {
                if (obj == null)
                    WriteArgumentNullException(message);
            }

            public static void IsNotNull(object obj, string message)
            {
                if (obj != null)
                    WriteArgumentNullException(message);
            }

            public static void IsNullOrEmpty(string obj, string message)
            {
                if (string.IsNullOrEmpty(obj))
                    WriteArgumentNullException(message);
            }

            public static void IsNotNullOrWhiteSpace(string obj, string message)
            {
                if (string.IsNullOrWhiteSpace(obj))
                    WriteArgumentNullException(message);
            }

            public static void IsTrue(bool condition, string message)
            {
                if (condition)
                    WriteArgumentException(message);
            }

            public static void IsFalse(bool condition, string message)
            {
                if (!condition)
                    WriteArgumentException(message);
            }

            public static void OutOfRange(int value, int min, int max, string message)
            {
                if (value < min || value > max)
                    WriteArgumentOutOfRangeException(message);
            }

            public static void OutOfRange(double value, double min, double max, string message)
            {
                if (value < min || value > max)
                    WriteArgumentOutOfRangeException(message);
            }

            public static void OutOfRange(decimal value, decimal min, decimal max, string message)
            {
                if (value < min || value > max)
                    WriteArgumentOutOfRangeException(message);
            }

            public static void OutOfRange(float value, float min, float max, string message)
            {
                if (value < min || value > max)
                    WriteArgumentOutOfRangeException(message);
            }

            public static void OutOfRange(long value, long min, long max, string message)
            {
                if (value < min || value > max)
                    WriteArgumentOutOfRangeException(message);
            }

            public static void OutOfRange(short value, short min, short max, string message)
            {
                if (value < min || value > max)
                    WriteArgumentOutOfRangeException(message);
            }

            public static void OutOfRange(byte value, byte min, byte max, string message)
            {
                if (value < min || value > max)
                    WriteArgumentOutOfRangeException(message);
            }

            public static void OutOfRange(ushort value, ushort min, ushort max, string message)
            {
                if (value < min || value > max)
                    WriteArgumentOutOfRangeException(message);
            }

            public static void OutOfRange(uint value, uint min, uint max, string message)
            {
                if (value < min || value > max)
                    WriteArgumentOutOfRangeException(message);
            }

            static void WriteArgumentNullException(string value)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("WoConsole:");
                // Write an entire line to the console with the string.
                Console.ResetColor();
                Console.WriteLine(" " + value);
            }

            static void WriteArgumentException(string value)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("WoConsole:");
                // Write an entire line to the console with the string.
                Console.ResetColor();
                Console.WriteLine(" " + value);
            }

            static void WriteArgumentOutOfRangeException(string value)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("WoConsole:");
                // Write an entire line to the console with the string.
                Console.ResetColor();
                Console.WriteLine(" " + value);
            }
        }
    }
}
