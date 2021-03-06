using Microsoft.EntityFrameworkCore;
using UniPortfolio.Misc.Services.EmailService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IEmailService, EmailService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration.GetConnectionString("db"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
