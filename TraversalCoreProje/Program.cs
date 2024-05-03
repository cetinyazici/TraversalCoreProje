using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using TraversalCoreProje.Models;

var builder = WebApplication.CreateBuilder(args);

// Veritabaný baðlantýsý ve kimlik doðrulama servisleri
builder.Services.AddDbContext<Context>();
// Identity sisteminde CustomIdentityValidator kullanýlýyor.
builder.Services.AddIdentity<AppUser, AppRole>(options =>
{
    // Burada gerekirse diðer kimlik doðrulama seçenekleri de yapýlandýrýlabilir.
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
})
.AddEntityFrameworkStores<Context>()
.AddErrorDescriber<CustomIdentityValidator>();

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddMvc();

// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.UseAuthentication(); // Kimlik doðrulamayý etkinleþtir
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
