using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProductAppCoreDBFirst.Models;
using ProductAppCoreDBFirst.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//fetch the connection string from AppSetting.json file
builder.Services.AddDbContext<NorthwindContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("NorthwindConnetion")));
var app = builder.Build();
//builder.Services.AddScoped<ICategoryRepository,CategoryServices > ();
builder.Services.AddScoped<ISupplierRepository,SupplierServices>();
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
