var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
var url = $"http://0.0.0.0:{port}";
var target = Environment.GetEnvironmentVariable("TARGET") ?? "World";


app.MapGet("/", () => "Hello World!");

app.Run(url);
