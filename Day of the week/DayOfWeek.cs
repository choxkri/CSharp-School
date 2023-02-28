class DayOfWeek
{
    public int index;

    public DayOfWeek(int i)
    { 
        this.index = i; 
    }

    public string IndexToDay(int i)
    {

        if (i > 6)
        {
            while (i > 6) 
            {
                i -= 7;
            }
        }

        else if (i < 0)
        {
            while (i < 0)
            {
                i += 7;
            }
        }

        string result = i switch
        {
            0 => "Monday",
            1 => "Tuesday",
            2 => "Wednesday",
            3 => "Thursday",
            4 => "Friday",
            5 => "Saturday",
            6 => "Sunday",
            _ => "default"
        };

        return result;

    }
}