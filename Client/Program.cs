using Blazored.Toast;
using IPOPHLTrademark.Client;
using IPOPHLTrademark.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzI1MjQ3MEAzMjM1MmUzMDJlMzBoVStMRjNldlhLd2NJaCtPc0tWVko5eklxL0g2WHhvb0R5R2tQOXZ3WEVNPQ==");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor();
builder.Services.AddBlazorBootstrap();
builder.Services.AddBlazoredToast();

builder.Services.AddTransient<ApplicantTypeManager>();

await builder.Build().RunAsync();
