using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<ICalculatorService, CalculatorService>();
builder.Services.AddMudServices();


await builder.Build().RunAsync();
