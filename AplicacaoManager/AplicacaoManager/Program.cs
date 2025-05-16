using AplicacaoManager.Messaging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddHostedService<RabbitMqStreamConsumerService>();
                services.AddSingleton<Form1>();
            })
            .Build();

            host.Start();

            
            var form = host.Services.GetRequiredService<Form1>();
            Application.Run(form);

            host.StopAsync().Wait();
        }
    }
}
