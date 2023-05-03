public class Pair<T1, T2>
{
    private T1 _fstSetter;

    public T1 Fst
    {
        get
        {
            return _fstSetter;
        }

        private set 
        {
            _fstSetter = value;
        }
    }

    private T2 _sndSetter;

    public T2 Snd
    {
        get
        {
            return _sndSetter;
        }

        private set
        {
            _sndSetter = value;
        }
    }

    public Pair(T1 fst, T2 snd)
    {
        this.Fst = fst;
        this.Snd = snd;
    }
}