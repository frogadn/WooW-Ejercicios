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



    //[WoLabel(Descripcion = nameof(WooW_Label.RespuestaHtml))]
    [WoModelMeta(
        ProcesoId = "SYS",
        TipoModelo = WoTypeModel.Response,
        Filtro = woGetListFilterType.Ninguno,
        Legacy  = "")]
    [JsonObject(MemberSerialization.OptOut)]
    public  partial class WoResponseHtml 
    {
        public WoResponseHtml()
        {
        }

        [Required]
        [StringLength(int.MaxValue)]
        //[Description(nameof(WooW_ModelData.Html))]
        //[WoLabelModel(Descripcion = nameof(WooW_ModelData.Html),
        //   Formulario = nameof(WooW_ModelLabel.Html),
        //   Grid = nameof(WooW_ModelLabel.Html),
        //   Help = nameof(WooW_ModelComment.Html))]
        [WoColumnMeta(
           Orden = 0,
           Longitud = 0,
           Precision = 0,
           TipoColumna = WoTypeColumn.Clob,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Volatil,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public string Html { get; set; }

    }
}
