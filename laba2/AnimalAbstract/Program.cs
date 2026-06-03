class Program
{
    public static void Main(string[] args)
    {
        Animal dog = new Dog();
        dog.SetName(Console.ReadLine()!);
        Console.WriteLine(dog.GetName());
        dog.Eat();
    }
}

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Eating");
    }
}

public abstract class Animal
{
    private string Name { get; set; }

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public abstract void Eat();
}