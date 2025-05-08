
using AplicacaoWeb.Controllers;

var builder = WebApplication.CreateBuilder(args);

//builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddHostedService<RabbitMqConsumerService>();

builder.Services.AddControllers()
    .AddXmlSerializerFormatters();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
