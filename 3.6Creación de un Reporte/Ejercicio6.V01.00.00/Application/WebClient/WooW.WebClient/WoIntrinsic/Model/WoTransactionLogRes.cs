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



    //[WoLabel(Descripcion = nameof(WooW_Label.LogDeTransaccion))]
    [WoModelMeta(
        ProcesoId = "SYS",
        TipoModelo = WoTypeModel.Response,
        Filtro = woGetListFilterType.Ninguno,
        Legacy  = "")]
    [JsonObject(MemberSerialization.OptOut)]
    public  partial class WoTransactionLogRes 
    {
        public WoTransactionLogRes()
        {
        }

        [Required]
        //[StringLength(int.MaxValue)]
        //[Description(nameof(WooW_ModelData.Requestbody))]
        //[WoLabelModel(Descripcion = nameof(WooW_ModelData.Requestbody),
        //   Formulario = nameof(WooW_ModelLabel.Requestbody),
        //   Grid = nameof(WooW_ModelLabel.Requestbody),
        //   Help = nameof(WooW_ModelComment.Requestbody))]
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
                public string RequestBody { get; set; }

        [Required]
        [StringLength(60)]
        //[Description(nameof(WooW_ModelData.Eventtype))]
        //[WoLabelModel(Descripcion = nameof(WooW_ModelData.Eventtype),
        //   Formulario = nameof(WooW_ModelLabel.Eventtype),
        //   Grid = nameof(WooW_ModelLabel.Eventtype),
        //   Help = nameof(WooW_ModelComment.Eventtype))]
        [WoColumnMeta(
           Orden = 1,
           Longitud = 60,
           Precision = 0,
           TipoColumna = WoTypeColumn.String,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Volatil,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public string EventType { get; set; }

        [Required]
        [StringLength(60)]
        //[Description(nameof(WooW_ModelData.Eventdate))]
        //[WoLabelModel(Descripcion = nameof(WooW_ModelData.Eventdate),
        //   Formulario = nameof(WooW_ModelLabel.Eventdate),
        //   Grid = nameof(WooW_ModelLabel.Eventdate),
        //   Help = nameof(WooW_ModelComment.Eventdate))]
        [WoColumnMeta(
           Orden = 2,
           Longitud = 60,
           Precision = 0,
           TipoColumna = WoTypeColumn.String,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Volatil,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public string EventDate { get; set; }

        [Required]
        [StringLength(60)]
        //[Description(nameof(WooW_ModelData.Modelbody))]
        //[WoLabelModel(Descripcion = nameof(WooW_ModelData.Modelbody),
        //   Formulario = nameof(WooW_ModelLabel.Modelbody),
        //   Grid = nameof(WooW_ModelLabel.Modelbody),
        //   Help = nameof(WooW_ModelComment.Modelbody))]
        [WoColumnMeta(
           Orden = 3,
           Longitud = 60,
           Precision = 0,
           TipoColumna = WoTypeColumn.String,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Volatil,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public string ModelBody { get; set; }

        [Required]
        [StringLength(60)]
        //[Description(nameof(WooW_ModelData.Userauthname))]
        //[WoLabelModel(Descripcion = nameof(WooW_ModelData.Userauthname),
        //   Formulario = nameof(WooW_ModelLabel.Userauthname),
        //   Grid = nameof(WooW_ModelLabel.Userauthname),
        //   Help = nameof(WooW_ModelComment.Userauthname))]
        [WoColumnMeta(
           Orden = 4,
           Longitud = 60,
           Precision = 0,
           TipoColumna = WoTypeColumn.String,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Volatil,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public string UserAuthName { get; set; }

        [Required]
        [StringLength(60)]
        //[Description(nameof(WooW_ModelData.Urn))]
        //[WoLabelModel(Descripcion = nameof(WooW_ModelData.Urn),
        //   Formulario = nameof(WooW_ModelLabel.Urn),
        //   Grid = nameof(WooW_ModelLabel.Urn),
        //   Help = nameof(WooW_ModelComment.Urn))]
        [WoColumnMeta(
           Orden = 5,
           Longitud = 60,
           Precision = 0,
           TipoColumna = WoTypeColumn.String,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Volatil,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public string Urn { get; set; }

    }
}
