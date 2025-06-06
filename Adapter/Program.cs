using System;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Service service = new Service();
            IClient iclient = new Adapter(service); // Aqui estamos utilizando o adaptador para adaptar o serviço ao cliente.

            Console.WriteLine(iclient.GetRequest());
            Console.ReadLine();
        }
    }
}