using Microsoft.EntityFrameworkCore;
using ProyectoCurso.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AutosContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration.GetConnectionString("BdConnec"));
    opts.EnableSensitiveDataLogging(true);
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<AutosContext>();
if (context != null)
    SeedData.SeedDataBase(context);

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
