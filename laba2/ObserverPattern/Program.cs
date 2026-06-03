namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoyalEnfield royalEnfield = new RoyalEnfield();
            Console.WriteLine(royalEnfield.GetBikeDetails());
            Console.WriteLine(royalEnfield.GetPrice().ToString());

            PromotionalOffer promotionalOffer = new PromotionalOffer(royalEnfield);
            promotionalOffer.PromotionalDiscount = 25000;
            Console.WriteLine(promotionalOffer.GetBikeDetails());
            Console.WriteLine(promotionalOffer.GetPrice().ToString());

            // Optional: Example with AccessoriesCharges
            AccessoriesCharges accessoriesCharges = new AccessoriesCharges(royalEnfield);
            accessoriesCharges.AccessoriesCharge = 5000;
            Console.WriteLine(accessoriesCharges.GetBikeDetails());
            Console.WriteLine(accessoriesCharges.GetPrice().ToString());
        }
    }

    public interface Bike
    {
        string GetBikeDetails();
        int GetPrice();
    }

    public class RoyalEnfield : Bike
    {
        public string GetBikeDetails()
        {
            return "Royal Enfield 150 F Stepway";
        }

        public int GetPrice()
        {
            return 150000;
        }
    }

    public abstract class BikeDecorator : Bike
    {
        public abstract string GetBikeDetails();
        public abstract int GetPrice();
    }

    public class PromotionalOffer : BikeDecorator
    {
        private Bike bike;
        public int PromotionalDiscount;

        public PromotionalOffer(Bike bike)
        {
            this.bike = bike;
        }

        public override string GetBikeDetails()
        {
            return bike.GetBikeDetails() + ". Promotional Offer";
        }

        public override int GetPrice()
        {
            return bike.GetPrice() - PromotionalDiscount;
        }
    }

    public class AccessoriesCharges : BikeDecorator
    {
        private Bike bike;
        public int AccessoriesCharge;

        public AccessoriesCharges(Bike bike)
        {
            this.bike = bike;
        }

        public override string GetBikeDetails()
        {
            return bike.GetBikeDetails() + ". Accessories Charges";
        }

        public override int GetPrice()
        {
            return bike.GetPrice() + AccessoriesCharge;
        }
    }
}