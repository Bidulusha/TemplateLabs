namespace Iterator
{
    public interface IInventory
    {
        string Name { get; set; }
        void PrintName();
    }

    public class Item : IInventory
    {
        public string Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }

    public class Backpack : IInventory, IEnumerable<IInventory>
    {
        private List<IInventory> list_ = new List<IInventory>();
        public string Name { get; set; }

        void IInventory.PrintName()
        {
            Console.WriteLine(Name);
        }

        public void AddSubordinate(IInventory subordinate)
        {
            list_.Add(subordinate);
        }

        public void RemoveSubordinate(IInventory subordinate)
        {
            list_.Remove(subordinate);
        }

        public IInventory GetSubordinate(int index)
        {
            return list_[index];
        }

        public IEnumerator<IInventory> GetEnumerator()
        {
            return list_.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item() { Name = "Sword" };

            Backpack chest = new Backpack() { Name = "Chest" };
            chest.AddSubordinate(item);

            Backpack backpack = new Backpack();
            backpack.AddSubordinate(chest);
            backpack.AddSubordinate(new Item { Name = "Shield" });
            backpack.AddSubordinate(new Item { Name = "Armor" });

            foreach (IInventory elements in backpack)
            {
                elements.PrintName();
            }
        }
    }
}