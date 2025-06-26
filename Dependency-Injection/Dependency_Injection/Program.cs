using System;

namespace Dependency_Injection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //// Configuração do Host para Injeção de Dependência
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            builder.Services.AddSingleton<IDataService, DataBaseService>();
            builder.Services.AddSingleton<IFileService, FileService>(); // Registrando os serviços de baixo nível para injeção de dependência
            builder.Services.AddSingleton<IMessageService, MessageService>(); // Registrando o serviço de mensagem para injeção de dependência

            builder.Services.AddSingleton<ILogger, Logger>(); // Registrando o Logger para injeção de dependência

            IHost host = builder.Build(); // Criando o host que irá gerenciar as instâncias
            host.Run(); // Inicia o host, que gerencia a criação e o ciclo de vida dos serviços registrados

            Logger logger = new Logger();
            Console.WriteLine("Send messages");

            logger.SaveMessageDataBase("Test message for DB");
            logger.SaveMessageFile("Test message for File");

            Console.ReadLine();
        }
    }
}