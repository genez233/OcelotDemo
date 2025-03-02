using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// 添加 Ocelot 服务
builder.Services.AddOcelot();
// 加载 Ocelot 配置文件
builder.Configuration.AddJsonFile("configuration.json");

builder.WebHost.UseUrls("http://*:5000");

var app = builder.Build();

// 使用 Ocelot 中间件
app.UseOcelot().Wait();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
