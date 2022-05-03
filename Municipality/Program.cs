var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "news",
    pattern: "{controller=News}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "news",
    pattern: "{controller=News}/{action=Detail}/{id?}");

app.MapControllerRoute(
    name: "aboutus",
    pattern: "{controller=AboutUs}/{action=AboutUs}/{id?}");

app.MapControllerRoute(
    name: "administration",
    pattern: "{controller=Administration}/{action=Administration}/{id?}");

app.MapControllerRoute(
    name: "gallery",
    pattern: "{controller=Gallery}/{action=Gallery}/{id?}");

app.MapControllerRoute(
    name: "contacts",
    pattern: "{controller=Contacts}/{action=Contacts}/{id?}");

app.MapControllerRoute(
    name: "useful",
    pattern: "{controller=Useful}/{action=Useful}/{id?}");

app.Run();
