public class Program
{
    public interface ICar
    {
        void build();
    }

    public class BMW : ICar
    {
        public void build()
        {
            Console.WriteLine("A BMW car has been created");
        }
    }

    public class Chevrolet : ICar
    {
        public void build()
        {
            Console.WriteLine("A Chevrolet car has been created");
        }
    }

    public class Renault : ICar
    {
        public void build()
        {
            Console.WriteLine("A Renault car has been created");
        }
    }

    class FacadeForCar
    {
        private ICar bmw;
        private ICar chevrolet;
        private ICar renault;

        public FacadeForCar()
        {
            this.bmw = new BMW();
            this.chevrolet = new Chevrolet();
            this.renault = new Renault();
        }

        public void buildBMW()
        {
            bmw.build();
        }

        public void buildChevrolet()
        {
            chevrolet.build();
        }

        public void buildRenault()
        {
            renault.build();
        }
    }

    public static class ProgramEntry
    {
        public static void Main(string[] args)
        {
            FacadeForCar facadeForCar = new FacadeForCar();
            facadeForCar.buildBMW();
            facadeForCar.buildRenault();
            facadeForCar.buildChevrolet();
        }
    }
}

