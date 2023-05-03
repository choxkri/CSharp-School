public class Triple<T1, T2, T3> : Pair<T1, T2>
{
    private T3 _trdSetter;

    public T3 Trd
    {
        get
        {
            return _trdSetter;
        }

        private set
        {
            _trdSetter = value;
        }
    }

    public Triple(T1 fst, T2 snd, T3 trd) : base(fst, snd)
    {
        this.Trd = trd;
    }
}