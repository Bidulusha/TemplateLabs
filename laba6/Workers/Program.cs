using System.Collections;

namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalWorker = 4;
            int totalAttr = 4;
            string[] stringWorker = new string[totalAttr];
            Worker workers = new Worker("", "", "", 0);

            Console.WriteLine("Enter information about employees (Name; Surname; Position; Salary)");

            for (int i = 0; i < totalWorker; i++)
            {
                stringWorker = Console.ReadLine().Split(';');
                Worker workerCurrent = new Worker(stringWorker[0], stringWorker[1], stringWorker[2], Convert.ToDouble(stringWorker[3]));

                workers.AddWorker(workerCurrent);
            }

            Console.WriteLine("Average Salary: {0}", workers.GetAverageSalary());
        }

        public class Worker : IEnumerable, IEnumerator
        {
            private List<Worker> workers = new List<Worker>();
            private int position = -1;
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public string Position { get; private set; }
            public double Salary { get; private set; }

            public Worker(string firstname, string lastName, string position, double salary)
            {
                FirstName = firstname;
                LastName = lastName;
                Position = position;
                Salary = salary;
            }

            public void AddWorker(Worker worker)
            {
                workers.Add(worker);
            }

            public double GetAverageSalary()
            {
                double totalSalary = 0;

                foreach (Worker worker in workers)
                {
                    totalSalary += worker.Salary;
                }

                return totalSalary / workers.Count;
            }

            public IEnumerator GetEnumerator()
            {
                return this;
            }

            public object Current
            {
                get { return workers[position]; }
            }

            public bool MoveNext()
            {
                if (position < workers.Count - 1)
                {
                    position++;
                    return true;
                }
                else
                {
                    Reset();
                    return false;
                }
            }

            public void Reset()
            {
                position = -1;
            }
        }
    }
}