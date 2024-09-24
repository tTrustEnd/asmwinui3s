using System.Diagnostics;
using SignalR.Hubs; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

var app = builder.Build();

// Middleware
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization(); 
// Map SignalR Hub
app.MapHub<ChatHub>("/chathub");

Debug.WriteLine("HELLO SignalR");

app.Run();
