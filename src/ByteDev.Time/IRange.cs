namespace ByteDev.Time
{
    public interface IRange<T>
    {
        T Start { get; }

        T End { get; }

        bool IsInRange(T value);

        bool IsInRange(IRange<T> range);
    }
}