using System.Runtime.CompilerServices;

// InternalsVisibleTo を使用する場合はこちらをコメントアウト解除
// [assembly: InternalsVisibleTo("SampleWebAPI.Tests")]

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.UseHttpsRedirection();
        app.UseRouting();

        app.MapGet("/", async context =>
        {
            await context.Response.WriteAsync("0");
        });

        app.Run();
    }
}
