class Program
{
    static void Main()
    {
        List<string> strings = new List<string>();
        for (int i = 0; i < 5; i++)
        {
            string input = Console.ReadLine();
            strings.Add(input);
        }

        var filteredStrings = strings.Where(s =>
            !string.IsNullOrEmpty(s) && (s.StartsWith("a") || s.EndsWith("a")))
            .ToList();

        Console.WriteLine("Final List:");
        foreach (var item in filteredStrings)
        {
            Console.WriteLine(item);
        }
    }
}