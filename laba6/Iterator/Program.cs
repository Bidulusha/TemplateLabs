namespace Iterator
{
    public interface IIterator
    {
        string FirstItem { get; }
        string NextItem { get; }
        string CurrentItem { get; }
        bool IsDone { get; }
    }

    public interface IAggregate
    {
        IIterator GetIterator();
        string this[int itemIndex] { get; set; }
        int Count { get; }
    }

    public class MyAggregate : IAggregate
    {
        List<string> values_ = null;

        public MyAggregate()
        {
            values_ = new List<string>();
        }

        public string this[int itemIndex]
        {
            get
            {
                if (itemIndex < values_.Count)
                {
                    return values_[itemIndex];
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                values_.Add(value);
            }
        }

        public int Count
        {
            get
            {
                return values_.Count;
            }
        }

        public IIterator GetIterator()
        {
            return new MyIterator(this);
        }
    }

    public class MyIterator : IIterator
    {
        IAggregate aggregate_ = null;
        int currentIndex_ = 0;

        public MyIterator(IAggregate aggregate)
        {
            aggregate_ = aggregate;
        }

        public string FirstItem
        {
            get
            {
                currentIndex_ = 0;
                return aggregate_[currentIndex_];
            }
        }

        public string NextItem
        {
            get
            {
                currentIndex_ += 1;
                if (IsDone == false)
                {
                    return aggregate_[currentIndex_];
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string CurrentItem
        {
            get
            {
                return aggregate_[currentIndex_];
            }
        }

        public bool IsDone
        {
            get
            {
                if (currentIndex_ < aggregate_.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyAggregate aggregate = new MyAggregate();
            for (int i = 0; i < 10; i++)
            {
                aggregate[i] = (i + 1).ToString();
            }

            IIterator iterator = aggregate.GetIterator();
            for (string s = iterator.FirstItem;
                iterator.IsDone == false;
                s = iterator.NextItem)
            {
                Console.WriteLine(s);
            }
        }
    }
}