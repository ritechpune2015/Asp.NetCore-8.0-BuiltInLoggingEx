var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Logging.ClearProviders(); //remove all provider
builder.Logging.AddConsole(); // console logging provider
builder.Logging.AddDebug(); //debug logging provider


var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
