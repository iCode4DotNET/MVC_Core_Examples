
//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.MapGet("/", () => "سلام دنیا");
//app.Run();



//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.UseWelcomePage();
//app.Run();

// Pay for Play

//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllers();
//var app = builder.Build();
//app.MapGet("/", () => "سلام دنیا");
//app.Run();



//No Service for Views

//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllers();
//var app = builder.Build();
//app.MapControllerRoute(
//               name: "default",
//               pattern: "{controller=Home}/{action=Index}/{id?}"
//               );
//app.Run();




//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllersWithViews();
//var app = builder.Build();
//app.MapControllerRoute(
//               name: "default",
//               pattern: "{controller=Home}/{action=Index}/{id?}"
//               );
//app.Run();




//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddMvcCore();
//var app = builder.Build();
//app.MapControllerRoute(
//               name: "default",
//               pattern: "{controller=Home}/{action=Index}/{id?}"
//               );
//app.Run();



//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddMvc();
//var app = builder.Build();
//app.MapControllerRoute(
//               name: "default",
//               pattern: "{controller=Home}/{action=Index}/{id?}"
//               );
//app.Run();



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.MapControllerRoute(
               name: "default",
               pattern: "{controller=Home}/{action=Index}/{id?}"
               );
app.Run();
