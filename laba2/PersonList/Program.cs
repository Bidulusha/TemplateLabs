class Program
{
    static void Main(string[] args)
    {
        List<Person> list = new List<Person>();

        for (int i = 0; i < 3; i++)
        {
            string name = Console.ReadLine()!;
            int age = int.Parse(Console.ReadLine()!);

            list.Add(
                new Person()
                {
                    Name = name,
                    Age = age
                });
        }

        foreach (Person per in list)
        {
            Console.WriteLine(per.ToString());
        }
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
        return Name + " - " + Age;
    }
}