using Application;
using DataAccess;

var builder = WebApplication.CreateBuilder(args);

var corsOrigins = builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplication(builder.Configuration);
builder.Services.AddDataAccess(builder.Configuration);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowedOrigins",
                      policy =>
                      {
                          policy.WithOrigins(corsOrigins)
                          .AllowCredentials()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowedOrigins");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
