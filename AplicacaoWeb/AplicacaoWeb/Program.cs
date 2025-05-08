using AplicacaoWeb.Data;
using AplicacaoWeb.Messaging;

var builder = WebApplication.CreateBuilder(args);

//builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddTransient<DataBaseCalls>();
builder.Services.AddControllers()
    .AddXmlSerializerFormatters();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHostedService<RabbitMqConsumerService>();

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
