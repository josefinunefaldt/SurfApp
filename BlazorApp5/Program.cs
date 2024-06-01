using BlazorApp5.Components;
using BlazorApp5.Data;
using MudBlazor.Services;
using Microsoft.EntityFrameworkCore;


using Microsoft.AspNetCore.Components.Web;

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;



     


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7088/") });




builder.Services.AddDbContext<ApplicationDbContext>(options =>// Dependency injectuion
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddMudServices();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
