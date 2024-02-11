using EmptyCRUDBlazorApp1.Models;
using EmptyCRUDBlazorApp1.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<PersonContext>(opt =>

               opt.UseSqlServer("server=DESKTOP-0HO4M5Q\\SQLEXPRESS;database=BlazorPersonDB1; trusted_connection=true; trust server certificate=true;")
           );

builder.Services.AddScoped<IPersonService, PersonService>();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
