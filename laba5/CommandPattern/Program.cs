namespace CommandPattern
{
    class Program
    {
        public class SpecialEnemy
        {
            public string CastSpell()
            {
                return "Using Spell";
            }
        }

        public interface IEnemy
        {
            string Attack();
        }

        public class EnemyAdapter : IEnemy
        {
            public string Attack()
            {
                SpecialEnemy enemy = new SpecialEnemy();
                return enemy.CastSpell();
            }
        }

        static void Main(string[] args)
        {
            IEnemy enemy = new EnemyAdapter();
            Console.WriteLine(enemy.Attack());
        }
    }
}