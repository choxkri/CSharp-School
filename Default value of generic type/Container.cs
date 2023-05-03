public class Container<T>
{
    private T _valueSetter;

    public T Value
    {
        get
        {
            return _valueSetter;
        }

        set 
        { 
            _valueSetter = value;
        }
    }

    public Container(T value)
    { 
        this.Value = value;
    }

    public void ResetValue()
    {
        this.Value = default(T);
    }
}