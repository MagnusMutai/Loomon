using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

//Register Syncfusion Licence
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NCaF5cXmZCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWXlccnRXR2ReV0dyX0M=");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
//Add Services to the container
//Add Syncfusion Blazor Service
builder.Services.AddSyncfusionBlazor();

await builder.Build().RunAsync();
