using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<CalculatorService>();

await builder.Build().RunAsync();
