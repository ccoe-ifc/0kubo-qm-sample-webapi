// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();  // HTTPSにリダイレクト
app.UseRouting();           // ルーティングを有効化

app.MapGet("/", async context =>
{
    await context.Response.WriteAsync("0");
});

app.Run();
