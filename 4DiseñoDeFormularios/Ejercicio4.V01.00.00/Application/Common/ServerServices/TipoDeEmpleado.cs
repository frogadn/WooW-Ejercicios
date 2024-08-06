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
    public partial class TipoDeEmpleado
    {

        public static WoODataResponse<TipoDeEmpleado> List(WoTargetConnection woTarget, TipoDeEmpleadoList ODataRequest)
        {
            return WoGenericService.ODataGet<TipoDeEmpleado>(woTarget, ODataRequest, true);
        }


        public static TipoDeEmpleado Get(WoTargetConnection woTarget, TipoDeEmpleadoGet GetRequest, WoGetFlags woGetFlags)
        {
            return TipoDeEmpleado.Get(woTarget, (string)GetRequest.GetObjectId(), woGetFlags | WoGetFlags.ApplyFilter );
        }  

        public static TipoDeEmpleado Get(WoTargetConnection woTarget, TipoDeEmpleadoGet GetRequest)
        {
            return TipoDeEmpleado.Get(woTarget, (string)GetRequest.GetObjectId(), WoGetFlags.None | WoGetFlags.ApplyFilter);
        }  

        public static TipoDeEmpleado Get(WoTargetConnection woTarget, string Id)
        {
            return TipoDeEmpleado.Get(woTarget, Id, WoGetFlags.None | WoGetFlags.ApplyFilter);
        }

        public static TipoDeEmpleado Get(WoTargetConnection woTarget, string Id, WoGetFlags woGetFlags)
        {
            return WoGenericService.Get<TipoDeEmpleado>(woTarget, Id, woGetFlags | WoGetFlags.ApplyFilter);
        }

        public static TipoDeEmpleado GetCheck(WoTargetConnection woTarget, string Id)
        {
            return WoGenericService.GetCheckIfNullThenExcept<TipoDeEmpleado>(woTarget, Id, WoGetFlags.None | WoGetFlags.ApplyFilter);
        }

        public static TipoDeEmpleado Single(WoTargetConnection woTarget, TipoDeEmpleadoSingle SingleRequest, WoGetFlags woGetFlags)
        {
            return TipoDeEmpleado.Single(woTarget, (string)SingleRequest.GetObjectId(), woGetFlags | WoGetFlags.ApplyFilter);
        }  

        public static TipoDeEmpleado Single(WoTargetConnection woTarget, TipoDeEmpleadoSingle SingleRequest)
        {
            return TipoDeEmpleado.Single(woTarget, (string)SingleRequest.GetObjectId(), WoGetFlags.None | WoGetFlags.ApplyFilter);
        }  

        public static TipoDeEmpleado Single(WoTargetConnection woTarget, string Id)
        {
            return TipoDeEmpleado.Single(woTarget, Id, WoGetFlags.None | WoGetFlags.ApplyFilter);
        }

        public static TipoDeEmpleado Single(WoTargetConnection woTarget, string Id, WoGetFlags woGetFlags)
        {
            return WoGenericService.Single<TipoDeEmpleado>(woTarget, Id, woGetFlags | WoGetFlags.ApplyFilter);
        }

        public static TipoDeEmpleado SingleCheck(WoTargetConnection woTarget, string Id)
        {
            return WoGenericService.SingleCheckIfNullThenExcept<TipoDeEmpleado>(woTarget, Id, WoGetFlags.None | WoGetFlags.ApplyFilter);
        }


        public static TipoDeEmpleado Post(WoTargetConnection woTarget, TipoDeEmpleadoNuevo dtoRequest)
        {


            return WoGenericServiceCatalog.Post<TipoDeEmpleadoNuevo, TipoDeEmpleado>(woTarget, dtoRequest,
                (int)eTipoDeEmpleado_WoState.Activo,
                null,
                null);
        }
        public static TipoDeEmpleado Put(WoTargetConnection woTarget, TipoDeEmpleadoActivar dtoRequest)
        {


            return WoGenericServiceCatalog.PutPatch<TipoDeEmpleadoActivar, TipoDeEmpleado>(woTarget, dtoRequest, woModifyVerb.Put,
                (int)eTipoDeEmpleado_WoState.Suspendido, (int)eTipoDeEmpleado_WoState.Activo,
                null,
                null);
        }

        public static TipoDeEmpleado Patch(WoTargetConnection woTarget, TipoDeEmpleadoActivar dtoRequest)
        {


            return WoGenericServiceCatalog.PutPatch<TipoDeEmpleadoActivar, TipoDeEmpleado>(woTarget, dtoRequest, woModifyVerb.Patch,
                (int)eTipoDeEmpleado_WoState.Suspendido, (int)eTipoDeEmpleado_WoState.Activo,
                null,
                null);
        }

        public static TipoDeEmpleado Put(WoTargetConnection woTarget, TipoDeEmpleadoSuspender dtoRequest)
        {


            return WoGenericServiceCatalog.PutPatch<TipoDeEmpleadoSuspender, TipoDeEmpleado>(woTarget, dtoRequest, woModifyVerb.Put,
                (int)eTipoDeEmpleado_WoState.Activo, (int)eTipoDeEmpleado_WoState.Suspendido,
                null,
                null);
        }

        public static TipoDeEmpleado Patch(WoTargetConnection woTarget, TipoDeEmpleadoSuspender dtoRequest)
        {


            return WoGenericServiceCatalog.PutPatch<TipoDeEmpleadoSuspender, TipoDeEmpleado>(woTarget, dtoRequest, woModifyVerb.Patch,
                (int)eTipoDeEmpleado_WoState.Activo, (int)eTipoDeEmpleado_WoState.Suspendido,
                null,
                null);
        }

        public static TipoDeEmpleado SoftDelete(WoTargetConnection woTarget, TipoDeEmpleadoDarDeBaja dtoRequest)
        {


            return WoGenericServiceCatalog.SoftDelete<TipoDeEmpleadoDarDeBaja, TipoDeEmpleado>(woTarget, dtoRequest,
                (int)eTipoDeEmpleado_WoState.Suspendido, (int)eTipoDeEmpleado_WoState.Baja,
                null,
                null);
        }
        public static TipoDeEmpleado Put(WoTargetConnection woTarget, TipoDeEmpleadoModificar dtoRequest)
        {


            return WoGenericServiceCatalog.PutPatch<TipoDeEmpleadoModificar, TipoDeEmpleado>(woTarget, dtoRequest, woModifyVerb.Put,
                (int)eTipoDeEmpleado_WoState.Activo, (int)eTipoDeEmpleado_WoState.Activo,
                null,
                null);
        }

        public static TipoDeEmpleado Patch(WoTargetConnection woTarget, TipoDeEmpleadoModificar dtoRequest)
        {


            return WoGenericServiceCatalog.PutPatch<TipoDeEmpleadoModificar, TipoDeEmpleado>(woTarget, dtoRequest, woModifyVerb.Patch,
                (int)eTipoDeEmpleado_WoState.Activo, (int)eTipoDeEmpleado_WoState.Activo,
                null,
                null);
        }



        public static TipoDeEmpleado Delete(WoTargetConnection woTarget, string id)
        {
            return TipoDeEmpleado.Delete(woTarget,
                new TipoDeEmpleadoBorrar()
                {
                    Id = id
                }
            );
        }

        public static TipoDeEmpleado Delete(WoTargetConnection woTarget, TipoDeEmpleadoBorrar dtoRequest)
        {

            return WoGenericServiceCatalog.Delete<TipoDeEmpleadoBorrar, TipoDeEmpleado>(woTarget,
                dtoRequest,
                null
            );
        }
  
    }
}
