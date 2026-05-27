class Program
{
    public static void Main(string[] args)
    {
        Character king = new King();
        WeaponBehavior weaponBehavior = new SwordBehavior();
        king.SetWeapon(weaponBehavior);
        king.fight();

        WeaponBehavior weaponBowSndArrowBehavior = new BowAndArrowBehavior();
        king.SetWeapon(weaponBowSndArrowBehavior);
        king.fight();
    }
    public interface WeaponBehavior
    {
        void UseWeapon();
    }
    public class SwordBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Attack with sword");
        }

    }
    public class KnightBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Attack with knife");
        }

    }
    public class BowBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Attack with bow");
        }

    }
    public class AxeBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Attack with axe");
        }

    }
    public class BowAndArrowBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Attack with bow and arrow");
        }

    }

    public abstract class Character
    {
        public WeaponBehavior weapon;

        public void SetWeapon(WeaponBehavior w)
        {
            weapon = w;
        }
        public abstract void fight();
    }
    public class King : Character
    {
        public override void fight()
        {
            Console.WriteLine("King: ");
            weapon.UseWeapon();
        }
    }

    public class Queen : Character
    {
        public override void fight()
        {
            Console.WriteLine("Queen: ");
        }
    }

    public class Knight : Character
    {
        public override void fight()
        {
            Console.WriteLine("Knight: ");
        }
    }

    public class Troll : Character
    {
        public override void fight()
        {
            Console.WriteLine("Troll: ");
        }
    }
}