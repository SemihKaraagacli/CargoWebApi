using AutoMapper;
using Cargo.Data.Models;
using Cargo.Data.Repositories;
using Cargo.Data.Repositories.Cargo;
using Cargo.Service.CargoService;
using Cargo.Service.Mappers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Cors 

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", buil =>
    {
        buil.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

//Register
builder.Services.AddDbContext<Context>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
//Dependency Injection
builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped<ICargoRepository, CargoRepository>();
builder.Services.AddScoped<ICargoService, CargoService>();

//Auto Mapper
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new Cargo.Service.Mappers.MappingProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors("AllowAll");

app.Run();
