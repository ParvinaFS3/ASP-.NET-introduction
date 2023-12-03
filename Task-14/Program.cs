var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Index}/{id?}"
);
app.MapAreaControllerRoute(
    name: "details",
    areaName: "Details",
    pattern: "{controller=User}/{action=UsersDetails}/{id?}"
);

app.Run();

