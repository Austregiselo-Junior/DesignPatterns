using System;
using System.Collections.Generic;

namespace Observer
{
    /// <summary>
    /// Publicador (Subject) que notifica os observadores registrados.
    /// </summary>
    public class Subject : ISubject
    {
        public int State { get; set; } // Estado do subject (publicador)
        private List<IObserver> _observers = new List<IObserver>(); // Lista de observadores registrados

        /// <summary>
        /// Acionar uma atualização em cada assinante.
        /// </summary>
        public void Notify()
        {
            Console.WriteLine("Subject (Publicador): Notificando os observadores");

            foreach (var observer in _observers)
            {
                observer.Update(this); // Chama o método Update de cada observador
            }
        }

        public void Subscribe(IObserver observer)
        {
            Console.WriteLine($"Subject (Publicador): Registrando o {observer}.");
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            Console.WriteLine($"Subject (Publicador): Removendo {observer}.");
            _observers.Remove(observer);
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\n Subject (Publicador): Eu tenho alguma coisa importante: Vou mudar!");

            this.State = new Random().Next(0, 10); // Simula uma mudança de estado

            Console.WriteLine($"Subject (Publicador): Meu estado mudou para: {State}");

            Notify(); // Notifica os observadores sobre a mudança de estado
        }
    }
}