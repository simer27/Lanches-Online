using Lanches_Online.Context;
using Lanches_Online.Models;
using Lanches_Online.Repositories;
using Lanches_Online.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<ILancheRepository,LancheRepository>();   
builder.Services.AddTransient<ICategoriaRepository,CategoriaRepository>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sp => CarrinhoCompra.GetCarrinho(sp));

builder.Services.AddMemoryCache();
builder.Services.AddSession();

string? mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseMySql(mySqlConnection,
        ServerVersion.AutoDetect(mySqlConnection)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();

app.MapControllerRoute(
    name: "categoriaFiltro",
    pattern: "Lanche/{action}/{categoria?}",
    defaults: new { Controller = "Lanche", Action = "List" }
);


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
