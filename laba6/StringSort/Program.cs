namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of strings separated by a symbol ';':");

            string input = Console.ReadLine();
            string[] stringList = input.Split(';');

            List<StringWrapper> list = new List<StringWrapper>();
            foreach (string str in stringList)
            {
                list.Add(new StringWrapper(str));
            }

            Console.WriteLine("Select a sort condition:");
            Console.WriteLine("1 - Ascending string length");
            Console.WriteLine("2 - Descending string length");

            int param = int.Parse(Console.ReadLine());

            switch (param)
            {
                case 1:
                    list.Sort();
                    break;
                case 2:
                    list.Sort();
                    list.Reverse();
                    break;
                default:
                    Console.WriteLine("Invalid param");
                    break;
            }

            Console.WriteLine("Sorted list of strings:");
            foreach (StringWrapper str in list)
            {
                Console.WriteLine(str.Value);
            }
        }
    }

    public class StringWrapper : IComparable<StringWrapper>
    {
        public string Value { get; private set; }

        public StringWrapper(string value)
        {
            Value = value;
        }

        public int CompareTo(StringWrapper other)
        {
            if (other == null)
            {
                return 0;
            }

            return Value.Length.CompareTo(other.Value.Length);
        }
    }
}