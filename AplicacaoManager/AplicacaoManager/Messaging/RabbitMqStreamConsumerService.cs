using Microsoft.Extensions.Hosting;
using RabbitMQ.Stream.Client;
using RabbitMQ.Stream.Client.Reliable;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AplicacaoManager.Messaging
{
    public class RabbitMqStreamConsumerService : BackgroundService
    {
        private readonly Form1 _form;

        public RabbitMqStreamConsumerService(Form1 form)
        {
            _form = form;
        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var streamSystem = await StreamSystem.Create(new StreamSystemConfig
            {
                UserName = "guest",
                Password = "guest",
                Endpoints = new List<EndPoint>() {
                    new IPEndPoint(IPAddress.Loopback, 5552)
                },
                VirtualHost = "/"
            });

            await streamSystem.CreateStream(new StreamSpec("Manager-Stream") 
            {
                MaxLengthBytes = 5_000_000_000
            });

            var consumer = await Consumer.Create(new ConsumerConfig(streamSystem, "Manager-Stream")
            {
                OffsetSpec = new OffsetTypeFirst(),
                MessageHandler = async (stream, _, _, message) =>
                {
                    _form.AddData(Encoding.UTF8.GetString(message.Data.Contents));

                    Debug.WriteLine($"Stream: {stream} - " + $"Received message: {Encoding.UTF8.GetString(message.Data.Contents)}");

                    await Task.CompletedTask;
                }
            });

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
