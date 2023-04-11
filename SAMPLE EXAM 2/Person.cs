public class Person
{
    public virtual string Name { get; }
    private int _ageSetter;
    public int Age
    {
        get
        {
            return _ageSetter;
        }

        private set
        {
            if (value < 0)
            {
                value = 0;
            }

            else
            {
                _ageSetter = value;
            }
        }
    }

    public Person(string n, int a)
    {
        this.Name = n;
        this.Age = a;
    }

    public void GrowOlder()
    {
        this.Age += 1;
    }

    public override string ToString()
    {
        return $"Name: {this.Name} \nAge: {this.Age}";
    }



}