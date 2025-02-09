namespace ConsoleApp1.src.BehavioralPatterns.Iterator
{
    public interface IIterator<T>
    {
        void Next();
        bool HasNext();
        // T = un type générique, que l'on nomme arbitrairement T
        T Current();
    }
}