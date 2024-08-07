// ------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta. WooW.SB ttModeloDTO
//     Versión del runtime: 1.0.0.0
//  
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated> 
// ------------------------------------------------------------------------------//
using WooW.Core;
using WooW.Model;
using ServiceStack;
using ServiceStack.DataAnnotations;
using System.Collections.Generic;
using WooW.Resources.Labels;
using WooW.Resources.ModelData;
using WooW.Resources.ModelLabel;
using WooW.Resources.ModelComment;
using Newtonsoft.Json;

namespace WooW.DTO
{


#if DEBUG
#if SERVER
    [RequiresAnyRole(nameof(Rol.DatSup))]
#endif
    [ValidateIsAuthenticated]
    [Tag("Bancos")]
    [Route("/api/BancoAutoQuery", "GET")]
    [JsonObject(MemberSerialization.OptOut)]
    public class BancoAutoQuery : QueryDb<Banco>, IWoInstanciaUdn
    {
    }
#endif

    #if SERVER
    [RequiresAnyRole(nameof(Rol.DatSup))]
    [AutoApply(Behavior.AuditQuery)]
    #endif
    [ValidateIsAuthenticated]
    [Tag("Bancos")]
    [Route("/api/BancoList", "GET")]
    [JsonObject(MemberSerialization.OptOut)]
    public class BancoList : IWoInstanciaUdn, IWoODataRequest
    {
        public string select { get; set; }
        public string filter { get; set; }
        public string orderby { get; set; }
        public bool count { get; set; }
        public int? top { get; set; }
        public int? skip { get; set; }
        public bool withref { get; set; }
        public string totalizer { get; set; }
    }

    #if SERVER
    [RequiresAnyRole(nameof(Rol.DatSup))]
    [AutoApply(Behavior.AuditQuery)]
    #endif
    [ValidateIsAuthenticated]
    [Tag("Bancos")]
    [Route("/api/BancoGet", "GET")]
    [JsonObject(MemberSerialization.OptOut)]
    public class BancoGet : IWoInstanciaUdn
    {
        public string Id { get; set; }
    }

    #if SERVER
    [RequiresAnyRole(nameof(Rol.DatSup))]
    [AutoApply(Behavior.AuditQuery)]
    #endif
    [ValidateIsAuthenticated]
    [Tag("Bancos")]
    [Route("/api/BancoSingle", "GET")]
    [JsonObject(MemberSerialization.OptOut)]
    public class BancoSingle : IWoInstanciaUdn
    {
        public string Id { get; set; }
    }


  
    #if SERVER
    [AutoApply(Behavior.AuditCreate)]
    [RequiresAnyRole(nameof(Rol.DatSup))]
    [RequiresAnyPermission(nameof(Permiso.PuedeDarDeAlta))]
    #endif
    [ValidateIsAuthenticated]
    [Tag("Bancos")]
    [Route("/api/BancoNuevo", "POST")]
    [AutoPopulate(nameof(Banco.WoState), Value = eBanco_WoState.Activo)]
    [WoModelBase(typeof(Banco))]
    [JsonObject(MemberSerialization.OptOut)]
    public class BancoNuevo : IWoInstanciaUdn, IReturn<Banco>
    {
        public BancoNuevo()
        {
  
        }

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
           TipoDato = WoTypeData.Primary,
           EsVisibleEnLookUp = true,
           Primaria = true,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
        public string Id { get; set; }

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
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.WoState)]
        [WoNoEditar]
        public eBanco_WoState WoState { get; set; }


    }
  

  
    #if SERVER
    [AutoApply(Behavior.AuditModify)]
    [RequiresAnyRole(nameof(Rol.DatSup))]
    [RequiresAnyPermission(nameof(Permiso.PuedeActivar))]
    #endif
    [ValidateIsAuthenticated]
    [Tag("Bancos")]
    [Route("/api/BancoActivar", "PUT PATCH")]
    [AutoPopulate(nameof(Banco.WoState), Value = eBanco_WoState.Activo)]
    [WoModelBase(typeof(Banco))]
    [JsonObject(MemberSerialization.OptOut)]
    public class BancoActivar : IWoInstanciaUdn, IReturn<Banco>
    {
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
           TipoDato = WoTypeData.Primary,
           EsVisibleEnLookUp = true,
           Primaria = true,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
        [WoNoEditar]
        public string Id { get; set; }

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
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.WoState)]
        [WoNoEditar]
        public eBanco_WoState? WoState { get; set; }

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
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Spin)]
        [WoNoEditar]
        public ulong RowVersion { get; set; }


    }

  
    #if SERVER
    [AutoApply(Behavior.AuditModify)]
    [RequiresAnyRole(nameof(Rol.DatSup))]
    [RequiresAnyPermission(nameof(Permiso.PuedeSuspender))]
    #endif
    [ValidateIsAuthenticated]
    [Tag("Bancos")]
    [Route("/api/BancoSuspender", "PUT PATCH")]
    [AutoPopulate(nameof(Banco.WoState), Value = eBanco_WoState.Suspendido)]
    [WoModelBase(typeof(Banco))]
    [JsonObject(MemberSerialization.OptOut)]
    public class BancoSuspender : IWoInstanciaUdn, IReturn<Banco>
    {
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
           TipoDato = WoTypeData.Primary,
           EsVisibleEnLookUp = true,
           Primaria = true,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
        [WoNoEditar]
        public string Id { get; set; }

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
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.WoState)]
        [WoNoEditar]
        public eBanco_WoState? WoState { get; set; }

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
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Spin)]
        [WoNoEditar]
        public ulong RowVersion { get; set; }

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
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = true,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
        public string SuspendInfo { get; set; }


    }

  
    #if SERVER
    [AutoApply(Behavior.AuditModify)]
    [RequiresAnyRole(nameof(Rol.DatSup))]
    [RequiresAnyPermission(nameof(Permiso.PuedeDarDeBaja))]
    #endif
    [ValidateIsAuthenticated]
    [Tag("Bancos")]
    [Route("/api/BancoDarDeBaja", "PUT PATCH")]
    [AutoPopulate(nameof(Banco.WoState), Value = eBanco_WoState.Baja)]
    [WoModelBase(typeof(Banco))]
    [JsonObject(MemberSerialization.OptOut)]
    public class BancoDarDeBaja : IWoInstanciaUdn, IReturn<Banco>
    {
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
           TipoDato = WoTypeData.Primary,
           EsVisibleEnLookUp = true,
           Primaria = true,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
        [WoNoEditar]
        public string Id { get; set; }

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
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.WoState)]
        [WoNoEditar]
        public eBanco_WoState? WoState { get; set; }

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
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Spin)]
        [WoNoEditar]
        public ulong RowVersion { get; set; }

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
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = true,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
        public string DeleteInfo { get; set; }


    }

  
    #if SERVER
    [AutoApply(Behavior.AuditModify)]
    [RequiresAnyRole(nameof(Rol.DatSup))]
    [RequiresAnyPermission(nameof(Permiso.PuedeModificar))]
    #endif
    [ValidateIsAuthenticated]
    [Tag("Bancos")]
    [Route("/api/BancoModificar", "PUT PATCH")]
    [AutoPopulate(nameof(Banco.WoState), Value = eBanco_WoState.Activo)]
    [WoModelBase(typeof(Banco))]
    [JsonObject(MemberSerialization.OptOut)]
    public class BancoModificar : IWoInstanciaUdn, IReturn<Banco>
    {
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
           TipoDato = WoTypeData.Primary,
           EsVisibleEnLookUp = true,
           Primaria = true,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Text)]
        [WoNoEditar]
        public string Id { get; set; }

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
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.WoState)]
        [WoNoEditar]
        public eBanco_WoState? WoState { get; set; }

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
           TipoDato = WoTypeData.Control,
           EsVisibleEnLookUp = false,
           Primaria = false,
           Nulo = false,
           Default = "",
           Legacy = "",
           TipoControl = WoTypeControl.Spin)]
        [WoNoEditar]
        public ulong RowVersion { get; set; }


    }

  

  
#if SERVER
    [RequiresAnyRole(nameof(Rol.DatSup))]
    [RequiresAnyPermission(nameof(Permiso.PuedeBorrar))]
#endif
    [ValidateIsAuthenticated]
    [Tag("Bancos")]
    [Route("/api/BancoBorrar", "DELETE")]
    [JsonObject(MemberSerialization.OptOut)]
    public class BancoBorrar : IWoInstanciaUdn, IReturn<Banco>
    {
        public string Id { get; set; }
    }
  
}