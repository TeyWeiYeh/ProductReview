using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using ProductReview.Server.Data;
using ProductReview.Server.Models;
using Microsoft.AspNetCore.Identity;
using ProductReview.Server.IRepository;
using ProductReview.Server.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<ApplicationUserClaimsPrincipalFactory>();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddClaimsPrincipalFactory<ApplicationUserClaimsPrincipalFactory>();

builder.Services.AddIdentityServer().AddApiAuthorization<ApplicationUser, ApplicationDbContext>(options => {

    // Note: This settings may be superfluous as the name claim 
    // is added by default.              
    options.IdentityResources["openid"].UserClaims.Add("name");
    options.ApiResources.Single().UserClaims.Add("name");

});

builder.Services.AddAuthentication().AddIdentityServerJwt();

builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(op =>op.SerializerSettings.ReferenceLoopHandling =Newtonsoft.Json.ReferenceLoopHandling.Ignore); 
builder.Services.AddRazorPages();

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseIdentityServer();
app.UseAuthorization();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
