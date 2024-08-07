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

    [EnumAsInt]
    public enum eBanco_WoState
    {
        Nulo = 0
        , Activo = 100
        , Suspendido = 500
        , Baja = 600
    }


    [WoLabel(Descripcion = nameof(WooW_Label.Bancos))]
    [WoModelMeta(
        ProcesoId = "SYS",
        TipoModelo = WoTypeModel.CatalogType,
        Filtro = woGetListFilterType.Ninguno,
        Legacy  = "")]
    [JsonObject(MemberSerialization.OptOut)]
    [WoLookUpConfig(KeyField = nameof(Id), DescriptionField = nameof(Nombre),
        Filter = "WoState eq 100",
        Select = nameof(Id) + "," + nameof(Nombre),
        OrderBy = nameof(Id))]
    public  partial class Banco : AWoCatalog
    {
        public Banco()
        {
            CreatedDate = DateTime.Today;
            ModifiedDate = DateTime.Today;
        }

        [PrimaryKey]
        [Required]
        [StringLength(6)]
        [Description(nameof(WooW_ModelData.Id))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.Id),
           Formulario = nameof(WooW_ModelLabel.Id),
           Grid = nameof(WooW_ModelLabel.Id),
           Help = nameof(WooW_ModelComment.Id))]
        [WoColumnMeta(
           Orden = 1,
           Longitud = 6,
           Precision = 0,
           TipoColumna = WoTypeColumn.String,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Primary,
           EsVisibleEnLookUp = true,
           Primaria = true,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public override string Id { get; set; }

        [Required]
        [StringLength(60)]
        [Description(nameof(WooW_ModelData.NombreCortoDelBanco))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.NombreCortoDelBanco),
           Formulario = nameof(WooW_ModelLabel.Nombre),
           Grid = nameof(WooW_ModelLabel.Nombre),
           Help = nameof(WooW_ModelComment.NombreCortoDelBanco))]
        [WoColumnMeta(
           Orden = 2,
           Longitud = 60,
           Precision = 0,
           TipoColumna = WoTypeColumn.String,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Volatil,
           EsVisibleEnLookUp = true,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public string Nombre { get; set; }

        [Required]
        [StringLength(60)]
        [Description(nameof(WooW_ModelData.RegistroFederalDeContribuyentes))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.RegistroFederalDeContribuyentes),
           Formulario = nameof(WooW_ModelLabel.Rfc),
           Grid = nameof(WooW_ModelLabel.Rfc),
           Help = nameof(WooW_ModelComment.RegistroFederalDeContribuyentes))]
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
                public string Rfc { get; set; }

        [Required]
        [Description(nameof(WooW_ModelData.State))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.State),
           Formulario = nameof(WooW_ModelLabel.State),
           Grid = nameof(WooW_ModelLabel.State),
           Help = nameof(WooW_ModelComment.State))]
        [WoColumnMeta(
           Orden = 200,
           Longitud = 0,
           Precision = 0,
           TipoColumna = WoTypeColumn.WoState,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.WoState)]
                public eBanco_WoState WoState { get; set; }

        [Required]
        [Description(nameof(WooW_ModelData.VersionEnDb))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.VersionEnDb),
           Formulario = nameof(WooW_ModelLabel.VersionEnDb),
           Grid = nameof(WooW_ModelLabel.VersionEnDb),
           Help = nameof(WooW_ModelComment.VersionEnDb))]
        [WoColumnMeta(
           Orden = 201,
           Longitud = 0,
           Precision = 0,
           TipoColumna = WoTypeColumn.Long,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Spin)]
                public override ulong RowVersion { get; set; }

        [StringLength(256)]
        [Description(nameof(WooW_ModelData.CausaDeSuspension))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.CausaDeSuspension),
           Formulario = nameof(WooW_ModelLabel.CausaDeSuspension),
           Grid = nameof(WooW_ModelLabel.CausaDeSuspension),
           Help = nameof(WooW_ModelComment.CausaDeSuspension))]
        [WoColumnMeta(
           Orden = 210,
           Longitud = 256,
           Precision = 0,
           TipoColumna = WoTypeColumn.String,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = true,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public string SuspendInfo { get; set; }

        [StringLength(64)]
        [Description(nameof(WooW_ModelData.SuspendidoPor))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.SuspendidoPor),
           Formulario = nameof(WooW_ModelLabel.SuspendidoPor),
           Grid = nameof(WooW_ModelLabel.SuspendidoPor),
           Help = nameof(WooW_ModelComment.SuspendidoPor))]
        [WoColumnMeta(
           Orden = 211,
           Longitud = 64,
           Precision = 0,
           TipoColumna = WoTypeColumn.String,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = true,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public string SuspendBy { get; set; }

        [Description(nameof(WooW_ModelData.FechaDeSuspension))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.FechaDeSuspension),
           Formulario = nameof(WooW_ModelLabel.FechaDeSuspension),
           Grid = nameof(WooW_ModelLabel.FechaDeSuspension),
           Help = nameof(WooW_ModelComment.FechaDeSuspension))]
        [WoColumnMeta(
           Orden = 212,
           Longitud = 0,
           Precision = 0,
           TipoColumna = WoTypeColumn.DateTime,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = true,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Date)]
                public DateTime ? SuspendDate { get; set; }

        [Required]

        [Description(nameof(WooW_ModelData.FechaDeCreacion))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.FechaDeCreacion),
           Formulario = nameof(WooW_ModelLabel.FechaDeCreacion),
           Grid = nameof(WooW_ModelLabel.FechaDeCreacion),
           Help = nameof(WooW_ModelComment.FechaDeCreacion))]
        [WoColumnMeta(
           Orden = 221,
           Longitud = 0,
           Precision = 0,
           TipoColumna = WoTypeColumn.DateTime,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "DateTime.Today",
           Legacy = "",
           TipoControl = WoTypeControl.Date)]
                public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(64)]
        [Description(nameof(WooW_ModelData.CreadoPor))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.CreadoPor),
           Formulario = nameof(WooW_ModelLabel.CreadoPor),
           Grid = nameof(WooW_ModelLabel.CreadoPor),
           Help = nameof(WooW_ModelComment.CreadoPor))]
        [WoColumnMeta(
           Orden = 222,
           Longitud = 64,
           Precision = 0,
           TipoColumna = WoTypeColumn.String,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public string CreatedBy { get; set; }

        [Required]

        [Description(nameof(WooW_ModelData.FechaDeModificacion))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.FechaDeModificacion),
           Formulario = nameof(WooW_ModelLabel.FechaDeModificacion),
           Grid = nameof(WooW_ModelLabel.FechaDeModificacion),
           Help = nameof(WooW_ModelComment.FechaDeModificacion))]
        [WoColumnMeta(
           Orden = 223,
           Longitud = 0,
           Precision = 0,
           TipoColumna = WoTypeColumn.DateTime,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "DateTime.Today",
           Legacy = "",
           TipoControl = WoTypeControl.Date)]
                public DateTime ModifiedDate { get; set; }

        [Required]
        [StringLength(64)]
        [Description(nameof(WooW_ModelData.ModificadoPor))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.ModificadoPor),
           Formulario = nameof(WooW_ModelLabel.ModificadoPor),
           Grid = nameof(WooW_ModelLabel.ModificadoPor),
           Help = nameof(WooW_ModelComment.ModificadoPor))]
        [WoColumnMeta(
           Orden = 224,
           Longitud = 64,
           Precision = 0,
           TipoColumna = WoTypeColumn.String,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public string ModifiedBy { get; set; }

        [StringLength(256)]
        [Description(nameof(WooW_ModelData.CausaDeBorrado))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.CausaDeBorrado),
           Formulario = nameof(WooW_ModelLabel.CausaDeBorrado),
           Grid = nameof(WooW_ModelLabel.CausaDeBorrado),
           Help = nameof(WooW_ModelComment.CausaDeBorrado))]
        [WoColumnMeta(
           Orden = 225,
           Longitud = 256,
           Precision = 0,
           TipoColumna = WoTypeColumn.String,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = true,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public string DeleteInfo { get; set; }

        [Description(nameof(WooW_ModelData.FechaDeBorrado))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.FechaDeBorrado),
           Formulario = nameof(WooW_ModelLabel.FechaDeBorrado),
           Grid = nameof(WooW_ModelLabel.FechaDeBorrado),
           Help = nameof(WooW_ModelComment.FechaDeBorrado))]
        [WoColumnMeta(
           Orden = 226,
           Longitud = 0,
           Precision = 0,
           TipoColumna = WoTypeColumn.DateTime,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = true,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Date)]
                public DateTime ? DeletedDate { get; set; }

        [StringLength(64)]
        [Description(nameof(WooW_ModelData.BorradoPor))]
        [WoLabelModel(Descripcion = nameof(WooW_ModelData.BorradoPor),
           Formulario = nameof(WooW_ModelLabel.BorradoPor),
           Grid = nameof(WooW_ModelLabel.BorradoPor),
           Help = nameof(WooW_ModelComment.BorradoPor))]
        [WoColumnMeta(
           Orden = 227,
           Longitud = 64,
           Precision = 0,
           TipoColumna = WoTypeColumn.String,
           ModeloId = "",
           DescripcionLookUp = "",
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = true,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
                public string DeletedBy { get; set; }

    }
}
