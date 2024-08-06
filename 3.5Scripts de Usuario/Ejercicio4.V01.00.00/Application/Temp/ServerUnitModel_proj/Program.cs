
///------------------------------------------------------------------------------------------------------------------
/// Código autogenerado por la template WoTemplateGenericClass en el path WooW.SB\WooW.SB\BlazorGenerator\BlazorTemplates\ServerTemplates\WoTemplateProgramServer.tt
/// Genera código consistente con la version de la prueba de concepto a dia 05-10-2023 En Blazor Wasm y Server
/// Este código es auto generado y su modificación puede causar que el código no se comporte como deveria ademas de
/// que se perderan los cambios realizados en el código al momento de la generación.
///------------------------------------------------------------------------------------------------------------------

using DevExpress.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ServiceStack.Blazor;
using Microsoft.AspNetCore.Components.Authorization;
using Blazor.Extensions.Logging;
using Blazored.LocalStorage;
using ServerUnitModel_proj.Auth;
using ServerUnitModel_proj;
using ServerUnitModel_proj.ControlModels;
using ServerUnitModel_proj.UserCode;
using WooW.Blazor.Resources;
using ServerUnitModel_proj.TransitionSettings;

var builder = WebApplication.CreateBuilder(args);

//Localization
builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

/// Configuracion de dev express
builder.Services.AddDevExpressBlazor();

/// DevExpress Report Viewer
builder.Services.AddDevExpressServerSideBlazorReportViewer();

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
builder.Services.AddScoped<ServerUnitModelControls>();
builder.Services.AddScoped<ServerUnitModelScriptsUser>();
builder.Services.AddScoped<ServerUnitModelTransitionSettings>();

/// Lista
builder.Services.AddScoped<ServerUnitModelGridListControls>();
builder.Services.AddScoped<ServerUnitModelGridListScriptsUser>();

/// Dependencias de las slaves


var app = builder.Build();

///app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

// Localization
var supportedCultures = new[] { "es-MX", "en-US" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

app.MapControllers();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

