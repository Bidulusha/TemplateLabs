namespace Iterator
{
    public interface IHeroState
    {
        void HandleInput(Hero hero, ConsoleKey key);
    }

    public class Hero
    {
        public string Name { get; set; }
        public IHeroState state { get; set; } = new IdleState();

        public void SetState(IHeroState state)
        {
            this.state = state;
        }

        public void HandleInput(ConsoleKey key)
        {
            state.HandleInput(this, key);
        }
    }

    public class IdleState : IHeroState
    {
        public void HandleInput(Hero hero, ConsoleKey key)
        {
            if (key == ConsoleKey.Spacebar)
            {
                hero.SetState(new JumpingState());
            }
            else
            {
                hero.SetState(this);
            }
        }
    }

    public class JumpingState : IHeroState
    {
        public void HandleInput(Hero hero, ConsoleKey key)
        {
            hero.SetState(new IdleState());
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Hero hero = new Hero() { Name = "Jumping Hero" };

            while (true)
            {
                ConsoleKey key = Console.ReadKey(intercept: true).Key;

                if (key == ConsoleKey.Escape)
                {
                    break;
                }

                hero.HandleInput(key);

                if (hero.state is JumpingState)
                {
                    Console.WriteLine("{0} is jumping!", hero.Name);
                }
                else
                {
                    Console.WriteLine("{0} is in idle pose", hero.Name);
                }
            }
        }
    }
}