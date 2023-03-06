using Newtonsoft.Json;

class Program
{
    public static void Main()
    {
        //Your code here
        StreamReader reader = new("Cars.json");
        string File2Json = reader.ReadToEnd();
        List<Car> listOfObjects = JsonConvert.DeserializeObject<List<Car>>(File2Json)!;
        reader.Close();
        reader.Dispose();

        for (int i = 0; i < 5; i++) 
        {
            foreach (Car car in listOfObjects) 
            {
                car.Drive();
            }
        }

        StreamWriter writer = new("Cars.json");
        string List2Json = JsonConvert.SerializeObject(listOfObjects);
        writer.Write(List2Json);
        writer.Close();
        writer.Dispose();
            
    }
}