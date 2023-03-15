class Program
{
    public static void Main()
    {
        Person john = new("John Doe");
        Student jane = new("Jane Doe");
        //Write your code here
        List<Person> list = new()
        {
            john,
            jane
        };

        foreach (Person person in list)
        {
            Console.WriteLine(person.Introduce());
            if (person is Student)
            {
                Console.WriteLine(((Student)person).Status());
            }
        }
    }

}