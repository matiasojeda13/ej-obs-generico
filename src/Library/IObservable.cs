namespace Observer
{
    public interface IObservable<X>
    {
        void Subscribe(IObserver<X> observer);
        void Unsubscribe(IObserver<X> observer);
        
    }
}