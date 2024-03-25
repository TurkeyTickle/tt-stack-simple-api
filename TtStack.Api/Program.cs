using FastEndpoints;

namespace TtStack.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddFastEndpoints();

        var app = builder.Build();

        app.UseHttpsRedirection();

        app.UseFastEndpoints();

        app.Run();
    }
}