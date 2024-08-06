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
    [Route("/api/WoSendMail", "POST")]
    //[WoLabel(Descripcion = nameof(WooW_Label.HelperMail))]
    [WoModelMeta(
        ProcesoId = "SYS",
        TipoModelo = WoTypeModel.Request,
        Filtro = woGetListFilterType.Ninguno,
        Legacy  = "")]
    [JsonObject(MemberSerialization.OptOut)]
    public  partial class WoSendMail : IWoInstanciaUdn
    {
        public WoSendMail()
        {
            EsHtml = false;
        }

        [Required]
        [StringLength(int.MaxValue)]
        //[Description(nameof(WooW_ModelData.De))]
        //[WoLabelModel(Descripcion = nameof(WooW_ModelData.De),
        //   Formulario = nameof(WooW_ModelLabel.De),
        //   Grid = nameof(WooW_ModelLabel.De),
        //   Help = nameof(WooW_ModelComment.De))]
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
                public string De { get; set; }

        [Required]
        [StringLength(int.MaxValue)]
        //[Description(nameof(WooW_ModelData.Para))]
        //[WoLabelModel(Descripcion = nameof(WooW_ModelData.Para),
        //   Formulario = nameof(WooW_ModelLabel.Para),
        //   Grid = nameof(WooW_ModelLabel.Para),
        //   Help = nameof(WooW_ModelComment.Para))]
        [WoColumnMeta(
           Orden = 1,
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
                public string Para { get; set; }

        [Required]
        [StringLength(int.MaxValue)]
        //[Description(nameof(WooW_ModelData.Asunto))]
        //[WoLabelModel(Descripcion = nameof(WooW_ModelData.Asunto),
        //   Formulario = nameof(WooW_ModelLabel.Asunto),
        //   Grid = nameof(WooW_ModelLabel.Asunto),
        //   Help = nameof(WooW_ModelComment.Asunto))]
        [WoColumnMeta(
           Orden = 2,
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
                public string Asunto { get; set; }

        [Required]
        [StringLength(int.MaxValue)]
        //[Description(nameof(WooW_ModelData.Mensaje))]
        //[WoLabelModel(Descripcion = nameof(WooW_ModelData.Mensaje),
        //   Formulario = nameof(WooW_ModelLabel.Mensaje),
        //   Grid = nameof(WooW_ModelLabel.Mensaje),
        //   Help = nameof(WooW_ModelComment.Mensaje))]
        [WoColumnMeta(
           Orden = 3,
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
                public string Mensaje { get; set; }

        [Required]

        //[Description(nameof(WooW_ModelData.EsHtml))]
        //[WoLabelModel(Descripcion = nameof(WooW_ModelData.EsHtml),
        //   Formulario = nameof(WooW_ModelLabel.EsHtml),
        //   Grid = nameof(WooW_ModelLabel.EsHtml),
        //   Help = nameof(WooW_ModelComment.EsHtml))]
        [WoColumnMeta(
           Orden = 4,
           Longitud = 0,
           Precision = 0,
           TipoColumna = WoTypeColumn.Boolean,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Volatil,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "false",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public bool EsHtml { get; set; }

    }
}
