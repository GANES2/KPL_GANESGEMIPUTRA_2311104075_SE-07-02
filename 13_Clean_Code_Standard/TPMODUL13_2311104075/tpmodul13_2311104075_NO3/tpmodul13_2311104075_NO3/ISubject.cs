namespace RefactoringGuru.DesignPatterns.Observer.Conceptual
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}