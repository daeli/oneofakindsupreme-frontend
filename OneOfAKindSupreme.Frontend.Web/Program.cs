using OneOfAKindSupreme.Frontend.Core.Interfaces.Api;
using OneOfAKindSupreme.Frontend.Infrastructure.Configuration;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi;
using OneOfAKindSupreme.Frontend.UseCases.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.RegisterInfrastructureServices();
builder.Services.RegisterUseCaseServices();
builder.Services.AddHttpClient<IApi, Api>(client => {
    var baseUrl = builder.Configuration.GetValue<string>("Api:BaseUrl") ?? "";
    client.BaseAddress = new Uri(baseUrl);
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
