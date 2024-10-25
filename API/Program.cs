using Application;
using Microsoft.ApplicationInsights.Extensibility;
using Serilog;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);


builder.Host.UseSerilog((context, loggerConfiguration) => loggerConfiguration
        .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}")
        .ReadFrom.Configuration(context.Configuration));


builder.Services.AddControllers()
    .AddJsonOptions(options =>
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase)
    .ConfigureApiBehaviorOptions(options =>
    {
        var builtInFactory = options.InvalidModelStateResponseFactory;

        options.InvalidModelStateResponseFactory = context =>
        {
            var logger = context.HttpContext.RequestServices
                                .GetRequiredService<ILogger<Program>>();

            logger.LogError("Invalid model state: {0}", context.ModelState);

            return builtInFactory(context);
        };
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplication(builder.Configuration);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowedOriginDev",
                      policy =>
                      {
                          policy.WithOrigins("https://localhost:3000")
                          .AllowCredentials()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                      });
    options.AddPolicy("AllowedOriginProd",
                      policy =>
                      {
                          policy.WithOrigins("https://mareksutora.sk")
                          .AllowCredentials()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                      });
});


var app = builder.Build();

app.UseSerilogRequestLogging();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
    app.UseCors("AllowedOriginDev");
}
else
{
    app.UseCors("AllowedOriginProd");
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
