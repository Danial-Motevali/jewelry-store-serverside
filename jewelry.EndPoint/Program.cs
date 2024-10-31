using jewelry.Domain.Contract.Repository;
using jewelry.Infectracture.Repository;
using jewerly.Application.Service;
using jewerly.Domain.Contract.Service;
using jewerly.Domain.SystemModel;
using jewerly.Infectracture.Data;
using jewerly.Infectracture.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlite"));
});

builder.Services.AddScoped<IUserService, userService>();

builder.Services.AddScoped<IGenericRepository<ApplicationUser>, GenericRepository<ApplicationUser>>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

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
