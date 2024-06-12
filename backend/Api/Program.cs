using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using BL;
using BL.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Configure Configuration (NEW)
IConfiguration configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IFanficService, FanficService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure CORS to allow requests from the frontend
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontendLocalhost3000", policy =>
        policy.WithOrigins("http://localhost:3000") // Frontend's URL
               .AllowAnyMethod()
               .AllowAnyHeader());
});

builder.Services.AddDbContext<ProjectDbContext>(options =>
{
    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use CORS policy
app.UseCors("AllowFrontendLocalhost3000");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


//builder.Services.AddDbContext<ProjectDbContext>(options => options.UseNpgsql("DefaultConnection"));