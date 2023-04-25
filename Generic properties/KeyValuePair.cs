public class KeyValuePair<T>
{
    private T _keysetter;
    public T TKey
    {
        get
        {
            return _keysetter;
        }

        set
        {
            _keysetter = value;
        }
    }

    private T _valuesetter;
    public T TValue
    {
        get
        {
            return _valuesetter;
        }

        set
        {
            _valuesetter = value;
        }
    }

    public KeyValuePair(T key, T value)
    {
        TKey = key;
        TValue = value;
    }
}