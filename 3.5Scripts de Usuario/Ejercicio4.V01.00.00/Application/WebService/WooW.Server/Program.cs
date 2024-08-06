using System.Diagnostics;
using System.Globalization;
using ServiceStack.FluentValidation;
using WooW.Core.Common;
using WooW.Core.Server;

WoLicence.Set();

// Por error en Failed invoking event handler: System.ObjectDisposedException: IFeatureCollection has been disposed
// Todo Inyectar Singleton
WoBackGroundCache tc = WoBackGroundCache.getInstance();

var builder = WebApplication.CreateBuilder(args);

ValidatorOptions.Global.DisplayNameResolver = (type, member, expression) =>
{
    if (member != null)
    {
        return "Campo[" + member.Name + "]";
    }
    return null;
};

var cultureInfo = new CultureInfo("es-MX");

CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseHttpsRedirection();
}

app.UseServiceStack(new AppHost());

app.Run();
