using Application.Interfaces;
using Application.UseCase.Students;
using Application.UseCase.Students.GetAll;
using Infrastructure.Command;
using Infrastructure.Persistence;
using Infrastructure.Querys;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// custom
////bd
var conectionString = builder.Configuration["ConectionString"];
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conectionString));

//inyectar la interfaz
builder.Services.AddScoped<IStudentServices, StudentServices>();
builder.Services.AddScoped<IStudentQuery, StudentQuery>();
builder.Services.AddScoped<IStudentCommand, StudentCommand>();


// agregar la dependencia <singleton,scope o transient> 
builder.Services.AddTransient<IServicesGetAll, ServicesGetAll>();
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

app.Run();
