using AplicacaoWeb.Data;
using AplicacaoWeb.Models;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace AplicacaoWeb.Messaging
{
    public class RabbitMqConsumerService : BackgroundService
    {
        private DataBaseCalls _dataBaseCalls;

        public RabbitMqConsumerService(DataBaseCalls dataBaseCalls)
        {
            _dataBaseCalls = dataBaseCalls;
        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {         
            var factory = new ConnectionFactory { 
                HostName = "localhost",
                Port = 5672,
                UserName = "guest",
                Password = "guest"
            };
            using var connection = await factory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(
                queue: "AplicacaoWeb",
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            var consumer = new AsyncEventingBasicConsumer(channel);

            consumer.ReceivedAsync += async (sender, ea) =>
            {
                var body = ea.Body.ToArray();
                string message = Encoding.UTF8.GetString(body);

                Debug.WriteLine(message); 

                try
                {
                    _dataBaseCalls.InsertTesteCallSP(JsonSerializer.Deserialize<TesteRelatorio>(message));
                } catch (Exception ex) {
                    Debug.WriteLine(ex.ToString()); 
                }
               


                await ((AsyncEventingBasicConsumer)sender).Channel.BasicAckAsync(ea.DeliveryTag, multiple: false);
            };

            await channel.BasicConsumeAsync("AplicacaoWeb", autoAck: false, consumer: consumer);

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(5000, stoppingToken);
            }       
        }
    }
}
