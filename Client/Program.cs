using Blazored.Toast;
using IPOPHLTrademark.Client;
using IPOPHLTrademark.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBPh8sVXJxS0d+X1RPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9nSXpRf0dhXXdec3xST2M=;Mgo+DSMBMAY9C3t2UFhhQlJBfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hTX5XdExhW3tWcHddT2RV;MzI0ODkyMUAzMjM1MmUzMDJlMzBBTlhoMVo4RmJjSVFCTVc0T0FpZWdhZlJYRGdoNzhaVHJEY21wOTBWbGZVPQ==");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor();
builder.Services.AddBlazorBootstrap();
builder.Services.AddBlazoredToast();

builder.Services.AddTransient<ApplicantTypeManager>();

await builder.Build().RunAsync();
