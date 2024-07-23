// ------------------------------------------------------------------------------
// <auto-generated> 
//     Este código fue generado por una herramienta. WooW.SB ttModelo
//     Versión del runtime: 1.0.0.0
//  
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
// ------------------------------------------------------------------------------//
using System; 
using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.DataAnnotations;
using WooW.Core;
using WooW.Resources.Labels;
using WooW.Resources.ModelData;
using WooW.Resources.ModelLabel;
using WooW.Resources.ModelComment;
using Newtonsoft.Json;


#nullable disable

namespace WooW.Model
{




    #if SERVER
    [AutoApply(Behavior.AuditQuery)]
#endif
    [Tag("WoIntrinsic")]
    [Route("/api/WoSendMailMime", "POST")]
    //[WoLabel(Descripcion = nameof(WooW_Label.HelperMail))]
    [WoModelMeta(
        ProcesoId = "SYS",
        TipoModelo = WoTypeModel.Request,
        Filtro = woGetListFilterType.Ninguno,
        Legacy  = "")]
    [JsonObject(MemberSerialization.OptOut)]
    public  partial class WoSendMailMime : IWoInstanciaUdn
    {
        public WoSendMailMime()
        {
        }

        [Required]
        //[Description(nameof(WooW_ModelData.MimeMessage))]
        //[WoLabelModel(Descripcion = nameof(WooW_ModelData.MimeMessage),
        //   Formulario = nameof(WooW_ModelLabel.MimeMessage),
        //   Grid = nameof(WooW_ModelLabel.MimeMessage),
        //   Help = nameof(WooW_ModelComment.MimeMessage))]
        [WoColumnMeta(
           Orden = 0,
           Longitud = 0,
           Precision = 0,
           TipoColumna = WoTypeColumn.Blob,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Volatil,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public byte[] MimeMessage { get; set; }

    }
}
