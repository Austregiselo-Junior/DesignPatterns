namespace Adapter
{
    /// <summary>
    /// Esse é o adaptador que recebe a interface do cliente e traduz as chamadas para o serviço.
    /// </summary>
    public class Adapter : IClient
    {
        private readonly Service _service;

        public Adapter(Service service)
        {
            _service = service;
        }

        /// <summary>
        /// Implementa a interface do cliente e dentro dela chama o serviço.
        /// </summary>
        /// <returns></returns>
        public string GetRequest()
        {
            return $" This is '{_service.GetSpecificRequest()}'";
        }
    }
}