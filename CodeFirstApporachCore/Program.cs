using CodeFirstApporachCore.Filters;
using CodeFirstApporachCore.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
//builder.Services.AddControllersWithViews().AddNewtonsoftJson(option=>
//option.SerializerSettings.ReferenceLoopHandling=Newtonsoft); 
//builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews(option => option.Filters.Add < WatchActionAsync>());
builder.Services.AddDbContext<MedicineStoreContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MedConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
    app.UseExceptionHandler("/Demo/CustomError");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=MedicineSuppliers}/{action=Index}/{id?}");

app.Run();
