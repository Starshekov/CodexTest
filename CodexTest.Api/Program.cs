using CodexTest.ServiceDefaults;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/", () => Results.Ok("Hello Codex"))
   .WithName("GetHelloCodex");

app.Run();
