public class ListWrapper<T>
{
    private List<T> _myList = new List<T>();

    public void Add(T item)
    {
        _myList.Add(item);
    }

    public T Get(int index)
    {
        return _myList[index];
    }

    public int Count()
    {
        return _myList.Count;
    }

    public int HighestCount<T2>(ListWrapper<T2> wrapper)
    {
        if (wrapper.Count() > _myList.Count()) 
        {
            return wrapper.Count();
        }

        return _myList.Count();
    }
}