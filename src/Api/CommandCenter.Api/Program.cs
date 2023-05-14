using CommandCenter.Application;
using CommandCenter.Application.Services;
using CommandCenter.Infrastrucutre;

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();

builder.Services.ConfigureApplicationServices();
builder.Services.AddInfrastructure(configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHub<SignalRService>("/PrinterHub");

app.Run();
