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


#region [ Home Special ]

//app.MapControllerRoute(
//name: "about",
//pattern: "about",
//defaults: new { controller = "Home", action = "about" }
//);


//app.MapControllerRoute(
//  name: "contact",
//  pattern: "contact",
//  defaults: new { controller = "Home", action = "Contact" }
//  );

app.MapControllerRoute(
name: "about",
pattern: "about-us",
defaults: new { controller = "Home", action = "about" }
);


app.MapControllerRoute(
  name: "contact",
  pattern: "contact-us",
  defaults: new { controller = "Home", action = "Contact" }
  );

#endregion

#region [ Person ]

app.MapControllerRoute(
name: "getFullName",
pattern: "person/GetByFullName/{id}/{name}/{family}",
defaults: new { controller = "Person", action = "GetByFullName" }
);

#endregion

#region [ Blog ]

app.MapControllerRoute(
name: "blog",
pattern: "blog/{category}/{title}",
defaults: new { controller = "Blog", action = "Get" }
);

#endregion

#region [ Product ]

app.MapControllerRoute(
name: "product",
pattern: "product/{id}",
defaults: new { controller = "Product", action = "Detail" }
); 
#endregion

#region [ Home Default ]

app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}"); 
#endregion


app.Run();
