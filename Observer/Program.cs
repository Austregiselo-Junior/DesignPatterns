using System;

namespace Observer
{
    internal class Program
    {
        /// <summary>
        /// Códigp do cliente.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var subject = new Subject();
            var oberverA = new ConcreteObserverA();
            var oberverB = new ConcreteObserverB();

            subject.Subscribe(oberverA);
            subject.Subscribe(oberverB);
            Console.ReadLine();

            subject.SomeBusinessLogic(); // Chama o método que altera o estado do subject e notifica os observadores.
            Console.ReadLine();

            subject.Unsubscribe(oberverB);
            subject.Unsubscribe(oberverB);
            Console.ReadLine();
        }
    }
}