using Microsoft.EntityFrameworkCore;
using EntregaRazor.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

builder.Services.AddDbContext<WarframeDB>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ubuntusqlserver") ?? throw new InvalidOperationException
    ("Conection String 'ubuntusqlserver' not found")));

var app = builder.Build();

app.UseStaticFiles();

async Task GetWarframes(HttpContext context)
{
    var requestData = await new StreamReader(context.Request.Body).ReadToEndAsync();
    context.Response.StatusCode = 200;
    await context.Response.WriteAsync(requestData);
}

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapPost("/tu-ruta", GetWarframes);
});


app.MapRazorPages();
app.Run();
