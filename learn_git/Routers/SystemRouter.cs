namespace learn_git.Routers;

public static class SystemRouter
{
    public static IEndpointRouteBuilder MapSystemRoutes(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/time", () =>
        {
            var now = DateTimeOffset.Now;
            return Results.Ok(new
            {
                now = now.ToString("O"),
                unixTimeSeconds = now.ToUnixTimeSeconds()
            });
        })
        .WithName("GetCurrentTime")
        .WithOpenApi();

        app.MapGet("/api/healthy", () => Results.Ok("healthy"))
            .WithName("GetStatus")
            .WithOpenApi();

        return app;
    }
}