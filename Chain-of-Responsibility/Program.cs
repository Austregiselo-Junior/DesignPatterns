using System;

namespace Chain_of_Responsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //A outra parte do código do cliente constrói a cadeia real.
            var monkey = new MonkeyHandler();
            var squireel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squireel).SetNext(dog); //Passa de um handler pro outro,
            Console.ReadLine();

            //O cliente deve ser capaz de enviar uma solicitação a qualquer manipulador, não apenas ao primeiro da cadeia.
            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            Client.ClientCode(monkey);
            Console.ReadLine();

            //OBS: Para sempre dar certo a sequência escolhida deve ser a mesma passada no cliente. Se eu preferir outra sequencia terei que ajustar a fila "monkey.SetNext(squireel).SetNext(dog)"
            // Por exemplo:

            dog.SetNext(squireel).SetNext(monkey);

            Console.WriteLine("Subchain: Dog > Squireel > monkey\n");
            Client.ClientCode(dog);
            Console.ReadLine();

            Client.ClientCode(squireel); // Aqui dá uma StackOverflowException porque quando o fluxo vai perguntar quem come MeatBall a cachorro está fora da sequência.
            Console.ReadLine();
        }
    }
}