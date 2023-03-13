using Newtonsoft.Json;
using System;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;

class Program
{
    public static void Main(string[] args)
    {
        StreamReader reader;
        List<Person> listOfObjects = new List<Person>();
        try
        {
            reader = new("People.json");
            string File2Json = reader.ReadToEnd();
            listOfObjects = JsonConvert.DeserializeObject<List<Person>>(File2Json)!;
            reader.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }


        for (int i = 0; i < listOfObjects.Count; i++)
        {
            foreach (Car car in listOfObjects[i].OwnedCars)
            {
                for (int x = 0; x < 5; x++)
                {
                    car.Drive();
                }
            }
        }

        try
        {
            StreamWriter writer = new("People.json");
            string List2Json = JsonConvert.SerializeObject(listOfObjects);
            writer.Write(List2Json);
            writer.Close();
        }

        catch (Exception ex) 
        {
            Console.WriteLine(ex.ToString());
        }
    }
}