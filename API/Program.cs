using Application;
using DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplication(builder.Configuration);
builder.Services.AddDataAccess(builder.Configuration);


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowedOrigin",
                          policy =>
                          {
                              policy.WithOrigins("https://localhost:3000")
                              .AllowCredentials()
                              .AllowAnyMethod()
                              .AllowAnyHeader();
                          });
    });
}
else
{
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowedOrigin",
                          policy =>
                          {
                              policy.WithOrigins("https://mareksutora.sk")
                              .AllowCredentials()
                              .AllowAnyMethod()
                              .AllowAnyHeader();
                          });
    });
}

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseCors("AllowedOrigin");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
