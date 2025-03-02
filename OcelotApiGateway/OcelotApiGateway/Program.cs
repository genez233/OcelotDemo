using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// ��� Ocelot ����
builder.Services.AddOcelot();
// ���� Ocelot �����ļ�
builder.Configuration.AddJsonFile("configuration.json");

builder.WebHost.UseUrls("http://*:5000");

var app = builder.Build();

// ʹ�� Ocelot �м��
app.UseOcelot().Wait();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
