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

        switch (i)
        {
            case 0:
                return "Monday";

            case 1:
                return "Tuesday";

            case 2:
                return "Wednesday";

            case 3:
                return "Thursday";

            case 4:
                return "Friday";

            case 5:
                return "Saturday";

            case 6:
                return "Sunday";

            default:
                return null;
        }
    }
}