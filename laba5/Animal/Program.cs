public class Animal
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }

    public int GetHumanAge()
    {
        return Age * 7;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter animal name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Animal animal = new Animal()
        {
            Name = name,
            Weight = weight,
            Age = age
        };

        Console.WriteLine("Animal: {0}", animal.Name);
        Console.WriteLine("Weight: {0}", animal.Weight);
        Console.WriteLine("Age: {0}", animal.Age);
        Console.WriteLine("Human Age: {0}", animal.GetHumanAge());
    }
}