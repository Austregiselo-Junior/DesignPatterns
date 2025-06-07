using System;

namespace Observer
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 10)
            {
                Console.WriteLine("ConcreteObserverA (Observador): Reagindo ao evento");
            }
        }
    }
}