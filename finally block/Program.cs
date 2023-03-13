using Newtonsoft.Json;
using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    public static void Main(string[] args)
    {
        StreamReader? reader = null;
        List<Person> listOfObjects = new List<Person>();
        try
        {
            reader = new("People.json");
        }

        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Missing JSON file. " + ex.Message);
        }



        try
        {
            string File2Json = reader.ReadToEnd();
            listOfObjects = JsonConvert.DeserializeObject<List<Person>>(File2Json)!;
        }

        catch (JsonReaderException ex)
        {
            Console.WriteLine("Invalid JSON. " + ex.Message);
        }

        finally
        {
            reader.Close();
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

        StreamWriter writer = new("People.json");
        string List2Json = JsonConvert.SerializeObject(listOfObjects);
        writer.Write(List2Json);
        writer.Close();
    }
}