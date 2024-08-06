
///------------------------------------------------------------------------------------------------------------------
/// Código autogenerado por la template WoTemplateGenericClass en el path WooW.SB\BlazorGenerator\BlazorTemplates\WasmTemplates\WoTemplateProgramWasm.tt
/// Genera código consistente con la version de la prueba de concepto a dia 05-10-2023 En Blazor Wasm y Server
/// Este código es auto generado y su modificación puede causar que el código no se comporte como deveria ademas de
/// que se perderan los cambios realizados en el código al momento de la generación.
///------------------------------------------------------------------------------------------------------------------

using Blazored.LocalStorage;
using DevExpress.Blazor;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ServiceStack.Blazor;
using WasmUnitModel_proj.Auth;
using WasmUnitModel_proj;
using WasmUnitModel_proj.ControlModels;
using WasmUnitModel_proj.UserCode;
using WasmUnitModel_proj.Localizer;
using WooW.Blazor.Resources;
using WasmUnitModel_proj.TransitionSettings;
var builder = WebAssemblyHostBuilder.CreateDefault(args);

/// Asigna el path de los recursos de atiquetas para el localizador.
builder.Services.AddLocalization(options => {
    options.ResourcesPath = "Resources";
});

/// Configuracion base de la aplicacion de blazor.
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

/// Configuracion de dev express
builder.Services.AddDevExpressBlazor();

/// DevExpress Report Viewer
builder.Services.AddDevExpressWebAssemblyBlazorReportViewer();

/// Carga del boostrap a dev express
builder.Services.Configure<DevExpress.Blazor.Configuration.GlobalOptions>(options => {
    options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
});

//Local storage
builder.Services.AddBlazoredLocalStorage();

// Service stack client
builder.Services.AddBlazorApiClient("https://localhost:5101",
    httpClient => httpClient.Timeout = new TimeSpan(days: 1, hours: 0, minutes: 0, seconds: 0));

// Autorización de blazor
builder.Services.AddAuthorizationCore();

// Inyección del proveedor de autenticación custom
builder.Services.AddScoped<WoAuthenticationStateProvider>();

// Configuración del proveedor de autenticación de blazor
builder.Services.AddScoped<AuthenticationStateProvider>
    ((authService => authService.GetRequiredService<WoAuthenticationStateProvider>()));

// Opciones de diseño, librería en NetCore.
builder.Services.AddSingleton<WoMenuDesingOptions>();


/// Dependencias para el login
builder.Services.AddScoped<WoLoginControls>();
builder.Services.AddScoped<LoginScriptsUser>();
/// Dependencias para el modelo de la prueba unitaria

/// Formulario
builder.Services.AddScoped<WasmUnitModelControls>();
builder.Services.AddScoped<WasmUnitModelScriptsUser>();
builder.Services.AddScoped<WasmUnitModelTransitionSettings>();

/// Lista
builder.Services.AddScoped<WasmUnitModelGridListControls>();
builder.Services.AddScoped<WasmUnitModelGridListScriptsUser>();

/// Dependencias de las slaves


/// Construye la aplicación.
var app = builder.Build();

/// Carga la cultura por defecto.
await app.SetDefaultCulture();

/// Arranca la aplicación.
await app.RunAsync();

