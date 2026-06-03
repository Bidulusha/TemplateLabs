class Program
{
    public static void Main(string[] args)
    {
        float radius = Convert.ToSingle(Console.ReadLine());

        double surface = 4 * Math.PI * (radius*radius);
        double volume = (4/3) * Math.PI * (radius*radius*radius);

        Console.WriteLine("Surface: " + surface);
        Console.WriteLine("Volume: " + volume);
    }
}