var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.Use(async (context, next) =>
{
    Console.WriteLine("Middleware 1: Before next()");
    await next();
    Console.WriteLine("Middleware 1: After next()");
});

app.Use(async (context, next) =>
{
    Console.WriteLine("Middleware 2: Before next()");
    await next();
    Console.WriteLine("Middleware 2: After next()");
});

app.Run(async context =>
{
    Console.WriteLine("Terminal Middleware: Handling request");
    await context.Response.WriteAsync("Hello from the terminal middleware!");
});


app.Run();