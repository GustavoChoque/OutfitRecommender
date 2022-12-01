using OutfitRecommender.Migrations;
using OutfitRecommender.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
/*
builder.Services.AddSession(options => {
    options.Cookie.Name = "MiCookie";
    options.IdleTimeout = TimeSpan.FromSeconds(5);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;

});*/
builder.Services.AddDbContext<OutfitRecommenderContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddSession();

var app = builder.Build();

/*
using (var context = new OutfitRecommenderContext()) {

    var userAdmin = new Usuario()
    {
        userName = "Admin",
        password = "qwerty"


    };
    context.Usuario.Add(userAdmin);
    context.SaveChanges();
}*/


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
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
