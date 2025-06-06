namespace Adapter
{
    /// <summary>
    /// O serviço contém algum comportamento útil, mas sua interface é incompatível com o código do cliente existente. O Adaptee precisa de alguma adaptação antes que o código do cliente possa usá-lo.
    /// Esse aqui simula o serviço de terceiros que não podemos modificar.
    /// </summary>
    public class Service
    {
        public string GetSpecificRequest()
        {
            return "Service: Specific request.";
        }
    }
}