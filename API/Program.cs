using Application;
using DataAccess;
using diploma_thesis_backend.API.Middlewares;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((hostingContext, loggerConfiguration) =>
{
    loggerConfiguration
        .ReadFrom.Configuration(hostingContext.Configuration);
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplication(builder.Configuration);
builder.Services.AddDataAccess(builder.Configuration);

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

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseSerilogRequestLogging();

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
