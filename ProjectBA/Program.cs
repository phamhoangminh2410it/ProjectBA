using Microsoft.EntityFrameworkCore;
using WkHtmlToPdfDotNet.Contracts;
using WkHtmlToPdfDotNet;
using ProjectBA.Services;
using ProjectBA.Models.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IBenhAnNgoaiKhoaServices, BenhAnNgoaiKhoaServices>();
builder.Services.AddScoped<IBenhAnNgoaiTruMatServices, BenhAnNgoaiTruMatServices>();
builder.Services.AddScoped<IBenhAnNgoaiTruRHMServices, BenhAnNgoaiTruRHMServices>();
builder.Services.AddScoped<IBenhAnNoiKhoaServices, BenhAnNoiKhoaServices>();
builder.Services.AddScoped<IBenhAnPhuKhoaServices, BenhAnPhuKhoaServices>();

builder.Services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
builder.Services.AddDbContext<HospitalContext>(c =>
        c.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

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

app.MapControllerRoute(
    name: "benhanngoaikhoa",
    pattern: "{controller=BenhAnNgoaiKhoa}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "benhanngoaitrumat",
    pattern: "{controller=BenhAnNgoaiTruMat}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "benhanngoaitrurhm",
    pattern: "{controller=BenhAnNgoaiTruRHM}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "benhannoikhoa",
    pattern: "{controller=BenhAnNoiKhoa}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "benhanphukhoa",
    pattern: "{controller=BenhAnPhuKhoa}/{action=Index}/{id?}");

app.Run();
