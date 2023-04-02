public interface IObservable : IObserver
{
    public void RegisterObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);

    public void NotifyObservers();
}