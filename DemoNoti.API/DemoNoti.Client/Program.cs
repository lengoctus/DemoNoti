using DemoNoti.Client.Entities;
using DemoNoti.Client.HubClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();
builder.Services.AddControllers().AddJsonOptions(ops =>
{
    ops.JsonSerializerOptions.PropertyNamingPolicy = null;
});

var mysqlConn = builder.Configuration.GetConnectionString("mySQLConn");
var migrationsAssembly = typeof(liveonsportContext).Assembly.GetName().Name;

builder.Services.AddDbContext<liveonsportContext>(options =>
    options.UseMySql
    (
        mysqlConn,
        ServerVersion.AutoDetect(mysqlConn),
        p => p.MigrationsAssembly(migrationsAssembly)
    ));


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

app.MapHub<BroadCastHub>("/notify");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
