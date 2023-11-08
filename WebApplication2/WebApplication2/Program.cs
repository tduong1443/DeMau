using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using WebApplication2.Reponsitory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<QlhangHoaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("QLHangHoaContext")));

builder.Services.AddScoped<ILoaiHangReponsitory, LoaiHangReponsitory>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
