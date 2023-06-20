public class Shelter
{
    public List<IAnimal> Animals;

    public Shelter()
    {
        Animals = new() { };
    }

    public void AddAnimal(IAnimal animal)
    {
        Animals.Add(animal);
    }

    public void SortAnimals()
    {
        Animals.Sort();
    }

    public T SearchAnimal<T>(string name) where T : IAnimal
    {
        foreach (IAnimal animal in Animals)
        {
            if (animal.GetType() == typeof(T) && animal.Name == name)
            {
                return (T)animal;
            }
        }

        return default(T);
    }
}