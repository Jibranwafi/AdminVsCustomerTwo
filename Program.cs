using AdminVsCustomerTwo.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AdminVsCustomerTwo.Areas.Identity.Data;
using Microsoft.AspNetCore.Components.Authorization;
using AdminVsCustomerTwo.Areas.Identity;
using Iuli.Cse19.CarRental.WebApp.Services;
using Iuli.Cse19.CarRental.WebApp.Common;

var builder = WebApplication.CreateBuilder(args);
/////
var connectionString = builder.Configuration.GetConnectionString("AdminVsCustomerTwoIdentityDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AdminVsCustomerTwoIdentityDbContextConnection' not found.");
///////////////
var mySqlDbVersion = ServerVersion.AutoDetect(connectionString);
/////////////////////////
builder.Services.AddDbContext<AdminVsCustomerTwoIdentityDbContext>(options => options.UseMySql(connectionString, mySqlDbVersion));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AdminVsCustomerTwoIdentityDbContext>();;

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();

builder.Services.AddScoped<CustomerEntityService>();
builder.Services.AddScoped<OwnerEntityService>();
builder.Services.AddScoped<CarEntityService>();
builder.Services.AddScoped<RentInfoEntityService>();
builder.Services.AddScoped<IAppDbContext>(provider => provider.GetService<AdminVsCustomerTwoIdentityDbContext>());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.UseAuthentication();;
app.UseAuthorization();

app.Run();
