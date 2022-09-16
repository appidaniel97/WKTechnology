using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WKTechnology.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>

    (options => options.UseMySql(
    "server=us-cdbr-east-06.cleardb.net;userid=b4f8bc383f2367;password=a7fcfd2b;database=heroku_fc7f8e3520ecc4f;port=3306",
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql")));

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Products}/{action=Index}/{id?}");

app.Run();
