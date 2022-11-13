using Microsoft.EntityFrameworkCore;
using SistemaInventario.Web.Application.DataContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Accediendo a la conexion declarada en el appsettings
//SistemaInventarioDBContext se pone a dispocision para todo el sistema

ConfigurationManager configuration = builder.Configuration;

var connectionSQL = configuration.GetConnectionString("ConexionSQL");
builder.Services.AddDbContext<SistemaInventarioDBContext>(options => options.UseSqlServer(connectionSQL));

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
