class Program
{
    public static void Main(string[] args)
    {
        double distance = Convert.ToDouble(Console.ReadLine());
        double h = Convert.ToDouble(Console.ReadLine());
        double m = Convert.ToDouble(Console.ReadLine());
        double s = Convert.ToDouble(Console.ReadLine());

        double timeBySec = (h * 3600) + (m * 60) + s;
        
        double mps = distance / timeBySec;
        double kph = (distance / 1000) / (timeBySec / 3600);
        double mph = kph / 1.609;

        Console.WriteLine("Speed in meters/sec is " + mps);
        Console.WriteLine("Speed in km/h is " + kph);
        Console.WriteLine("Speed in miles/h is " + mph);
    } 
}