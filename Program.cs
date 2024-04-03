var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // MVC sablonu kurmak icin baglaniyor.
var app = builder.Build();

app.UseStaticFiles(); //Bu sayede wwwroot altinda ki dosyalara erisebilecegim

app.UseRouting(); // 
//mvc
//rest api
//razaor pages

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);


//Controller(action)/id?
//app.MapDefaultControllerRoute();

app.Run();
