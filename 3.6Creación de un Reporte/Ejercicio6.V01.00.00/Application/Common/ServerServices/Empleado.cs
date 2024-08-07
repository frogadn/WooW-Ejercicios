// ------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta. WooW.SB ttModeloServicio
//     Versión del runtime: 1.0.0.0
//  
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
// ------------------------------------------------------------------------------//
using WooW.Core.Server;
using WooW.Core;
using WooW.Core.Common;
using WooW.DTO;
using ServiceStack;
using ServiceStack.OrmLite;
using System.Collections.Generic;

namespace WooW.Model
{
    public partial class Empleado
    {

        public static WoODataResponse<Empleado> List(WoTargetConnection woTarget, EmpleadoList ODataRequest)
        {
            return WoGenericService.ODataGet<Empleado>(woTarget, ODataRequest, true);
        }


        public static Empleado Get(WoTargetConnection woTarget, EmpleadoGet GetRequest, WoGetFlags woGetFlags)
        {
            return Empleado.Get(woTarget, (string)GetRequest.GetObjectId(), woGetFlags | WoGetFlags.ApplyFilter );
        }  

        public static Empleado Get(WoTargetConnection woTarget, EmpleadoGet GetRequest)
        {
            return Empleado.Get(woTarget, (string)GetRequest.GetObjectId(), WoGetFlags.None | WoGetFlags.ApplyFilter);
        }  

        public static Empleado Get(WoTargetConnection woTarget, string Id)
        {
            return Empleado.Get(woTarget, Id, WoGetFlags.None | WoGetFlags.ApplyFilter);
        }

        public static Empleado Get(WoTargetConnection woTarget, string Id, WoGetFlags woGetFlags)
        {
            return WoGenericService.Get<Empleado>(woTarget, Id, woGetFlags | WoGetFlags.ApplyFilter);
        }

        public static Empleado GetCheck(WoTargetConnection woTarget, string Id)
        {
            return WoGenericService.GetCheckIfNullThenExcept<Empleado>(woTarget, Id, WoGetFlags.None | WoGetFlags.ApplyFilter);
        }

        public static Empleado Single(WoTargetConnection woTarget, EmpleadoSingle SingleRequest, WoGetFlags woGetFlags)
        {
            return Empleado.Single(woTarget, (string)SingleRequest.GetObjectId(), woGetFlags | WoGetFlags.ApplyFilter);
        }  

        public static Empleado Single(WoTargetConnection woTarget, EmpleadoSingle SingleRequest)
        {
            return Empleado.Single(woTarget, (string)SingleRequest.GetObjectId(), WoGetFlags.None | WoGetFlags.ApplyFilter);
        }  

        public static Empleado Single(WoTargetConnection woTarget, string Id)
        {
            return Empleado.Single(woTarget, Id, WoGetFlags.None | WoGetFlags.ApplyFilter);
        }

        public static Empleado Single(WoTargetConnection woTarget, string Id, WoGetFlags woGetFlags)
        {
            return WoGenericService.Single<Empleado>(woTarget, Id, woGetFlags | WoGetFlags.ApplyFilter);
        }

        public static Empleado SingleCheck(WoTargetConnection woTarget, string Id)
        {
            return WoGenericService.SingleCheckIfNullThenExcept<Empleado>(woTarget, Id, WoGetFlags.None | WoGetFlags.ApplyFilter);
        }


        public static Empleado Post(WoTargetConnection woTarget, EmpleadoNuevo dtoRequest)
        {
            var Pre = new EmpleadoPreConditions(woTarget);

            var Post = new EmpleadoPostConditions(woTarget);

            return WoGenericServiceCatalog.Post<EmpleadoNuevo, Empleado>(woTarget, dtoRequest,
                (int)eEmpleado_WoState.Activo,
                [
                    Pre.EmpleadoNuevo,
                ],
                [
                    Post.EmpleadoNuevo,
                ]);
        }
        public static Empleado Put(WoTargetConnection woTarget, EmpleadoActivar dtoRequest)
        {
            var Pre = new EmpleadoPreConditions(woTarget);

            var Post = new EmpleadoPostConditions(woTarget);

            return WoGenericServiceCatalog.PutPatch<EmpleadoActivar, Empleado>(woTarget, dtoRequest, woModifyVerb.Put,
                (int)eEmpleado_WoState.Suspendido, (int)eEmpleado_WoState.Activo,
                [
                    Pre.EmpleadoActivar,
                ],
                [
                    Post.EmpleadoActivar,
                ]);
        }

        public static Empleado Patch(WoTargetConnection woTarget, EmpleadoActivar dtoRequest)
        {
            var Pre = new EmpleadoPreConditions(woTarget);

            var Post = new EmpleadoPostConditions(woTarget);

            return WoGenericServiceCatalog.PutPatch<EmpleadoActivar, Empleado>(woTarget, dtoRequest, woModifyVerb.Patch,
                (int)eEmpleado_WoState.Suspendido, (int)eEmpleado_WoState.Activo,
                [
                    Pre.EmpleadoActivar,
                ],
                [
                    Post.EmpleadoActivar,
                ]);
        }

        public static Empleado Put(WoTargetConnection woTarget, EmpleadoSuspender dtoRequest)
        {
            var Pre = new EmpleadoPreConditions(woTarget);

            var Post = new EmpleadoPostConditions(woTarget);

            return WoGenericServiceCatalog.PutPatch<EmpleadoSuspender, Empleado>(woTarget, dtoRequest, woModifyVerb.Put,
                (int)eEmpleado_WoState.Activo, (int)eEmpleado_WoState.Suspendido,
                [
                    Pre.EmpleadoSuspender,
                ],
                [
                    Post.EmpleadoSuspender,
                ]);
        }

        public static Empleado Patch(WoTargetConnection woTarget, EmpleadoSuspender dtoRequest)
        {
            var Pre = new EmpleadoPreConditions(woTarget);

            var Post = new EmpleadoPostConditions(woTarget);

            return WoGenericServiceCatalog.PutPatch<EmpleadoSuspender, Empleado>(woTarget, dtoRequest, woModifyVerb.Patch,
                (int)eEmpleado_WoState.Activo, (int)eEmpleado_WoState.Suspendido,
                [
                    Pre.EmpleadoSuspender,
                ],
                [
                    Post.EmpleadoSuspender,
                ]);
        }

        public static Empleado SoftDelete(WoTargetConnection woTarget, EmpleadoDarDeBaja dtoRequest)
        {
            var Pre = new EmpleadoPreConditions(woTarget);

            var Post = new EmpleadoPostConditions(woTarget);

            return WoGenericServiceCatalog.SoftDelete<EmpleadoDarDeBaja, Empleado>(woTarget, dtoRequest,
                (int)eEmpleado_WoState.Suspendido, (int)eEmpleado_WoState.Baja,
                [
                    Pre.EmpleadoDarDeBaja,
                ],
                [
                    Post.EmpleadoDarDeBaja,
                ]);
        }
        public static Empleado Put(WoTargetConnection woTarget, EmpleadoModificar dtoRequest)
        {
            var Pre = new EmpleadoPreConditions(woTarget);

            var Post = new EmpleadoPostConditions(woTarget);

            return WoGenericServiceCatalog.PutPatch<EmpleadoModificar, Empleado>(woTarget, dtoRequest, woModifyVerb.Put,
                (int)eEmpleado_WoState.Activo, (int)eEmpleado_WoState.Activo,
                [
                    Pre.EmpleadoModificar,
                ],
                [
                    Post.EmpleadoModificar,
                ]);
        }

        public static Empleado Patch(WoTargetConnection woTarget, EmpleadoModificar dtoRequest)
        {
            var Pre = new EmpleadoPreConditions(woTarget);

            var Post = new EmpleadoPostConditions(woTarget);

            return WoGenericServiceCatalog.PutPatch<EmpleadoModificar, Empleado>(woTarget, dtoRequest, woModifyVerb.Patch,
                (int)eEmpleado_WoState.Activo, (int)eEmpleado_WoState.Activo,
                [
                    Pre.EmpleadoModificar,
                ],
                [
                    Post.EmpleadoModificar,
                ]);
        }



        public static Empleado Delete(WoTargetConnection woTarget, string id)
        {
            return Empleado.Delete(woTarget,
                new EmpleadoBorrar()
                {
                    Id = id
                }
            );
        }

        public static Empleado Delete(WoTargetConnection woTarget, EmpleadoBorrar dtoRequest)
        {
            var Pre = new EmpleadoPreConditions(woTarget);

            return WoGenericServiceCatalog.Delete<EmpleadoBorrar, Empleado>(woTarget,
                dtoRequest,
                [
                    Pre.EmpleadoBorrar,
                ]
            );
        }
  
    }
}
