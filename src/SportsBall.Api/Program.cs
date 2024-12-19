using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddOptions<ApiSettings>()
    .BindConfiguration("AzureOpenAI")
    .ValidateDataAnnotations()
    .ValidateOnStart();

builder.Services.AddSingleton(sp =>
    sp.GetRequiredService<IOptions<ApiSettings>>().Value);

builder.Services.AddOpenApi();

var app = builder.Build();

// Validate configuration at startup
var apiSettings = app.Services.GetRequiredService<ApiSettings>();

var kernelBuilder = Kernel
    .CreateBuilder()
    .AddAzureOpenAIChatCompletion(apiSettings.ModelId, apiSettings.Endpoint, apiSettings.ApiKey);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();

