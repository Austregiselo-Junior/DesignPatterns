namespace Observer
{
    /// <summary>
    /// Interface do publicador (Subject).
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Registra um observador.
        /// </summary>
        /// <param name="observer"></param>
        void Subscribe(IObserver observer);

        /// <summary>
        /// Cancela o registro de um observador.
        /// </summary>
        /// <param name="observer"></param>
        void Unsubscribe(IObserver observer);

        /// <summary>
        /// Atualiza os observadores registrados.
        /// </summary>
        void Notify();
    }
}