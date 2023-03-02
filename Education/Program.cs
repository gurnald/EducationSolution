using Microsoft.EntityFrameworkCore;
using Education.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<EducationDbContext>(x =>
    x.UseSqlServer(builder.Configuration.GetConnectionString("EducationDbContext") ?? throw new InvalidOperationException("Connection string 'EducationDbContext' not found.")));

// Add services to the container.

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
