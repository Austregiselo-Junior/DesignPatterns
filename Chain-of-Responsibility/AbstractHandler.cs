namespace Chain_of_Responsibility
{
    /// <summary>
    /// O comportamento padrão de encadeamento pode ser implementado em uma classe de manipulador de base.
    /// </summary>
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Retornar um manipulador a partir daqui nos permitirá vincular manipuladores de maneira conveniente, assim: monkey.SetNext(squirrel).SetNext(dog);
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public IHandler SetNext(IHandler handler)
        {
            return _nextHandler = handler;
        }
    }
}