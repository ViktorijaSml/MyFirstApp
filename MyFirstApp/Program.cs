var builder = WebApplication.CreateBuilder(args); //loads configuration enviroment and default services
var app = builder.Build(); //instance of web application

app.MapGet("/", () => "Hello World!");

app.Run(); //starts the server
