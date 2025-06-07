namespace Observer
{
    /// <summary>
    /// Recebe a atualização do publicador (ISubject).
    /// </summary>
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}