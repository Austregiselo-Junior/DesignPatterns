using System;
using System.Collections.Generic;

namespace Chain_of_Responsibility
{
    /// <summary>
    /// O código do cliente geralmente é adequado para trabalhar com um único manipulador. Na maioria dos casos, ele nem mesmo sabe que o manipulador faz parte de uma cadeia.
    /// </summary>
    public class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "MeatBall" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }
}