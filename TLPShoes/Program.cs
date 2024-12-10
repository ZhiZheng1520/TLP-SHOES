using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TLPShoes.Areas.Identity.Data;
using TLPShoes.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("TLPShoesContextConnection") ?? throw new InvalidOperationException("Connection string 'TLPShoesContextConnection' not found.");

builder.Services.AddDbContext<TLPShoesContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<TLPShoesUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<TLPShoesContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseEndpoints(endpoints =>
//{
//    // Map Razor Pages for areas and non-area pages
//    endpoints.MapRazorPages();
//});

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapRazorPages();
app.Run();
