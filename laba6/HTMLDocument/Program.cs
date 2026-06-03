namespace Html
{
    public abstract class Document
    {
        public void Print()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        public abstract void PrintHeader();
        public abstract void PrintBody();
        public abstract void PrintFooter();
    }

    public class HTMLDocument : Document
    {
        public override void PrintHeader()
        {
            Console.WriteLine("Html document header");
        }

        public override void PrintBody()
        {
            Console.WriteLine("Html document body");
        }

        public override void PrintFooter()
        {
            Console.WriteLine("Html document footer");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HTMLDocument hDocument = new HTMLDocument();
            hDocument.Print();

            HTMLDocument zDocument = new HTMLDocument();
            zDocument.Print();
        }
    }
}