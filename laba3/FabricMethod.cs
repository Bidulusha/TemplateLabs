using System;

public interface IWeapon
{
    string Item();
}

public interface IAmor
{
    string Item();
}

public class Sword : IWeapon
{
    public string Item()
    {
        return "Sword";
    }
}

public class Wand : IWeapon
{
    public string Item()
    {
        return "Wand";
    }
}

public class BodyArmor : IAmor
{
    public string Item()
    {
        return "Steel Body Armor";
    }
}

public class Cloak : IAmor
{
    public string Item()
    {
        return "Cloak";
    }
}

public interface IEnemyFactory
{
    IWeapon GetWeapon();
    IAmor GetAmor();
}

public class Warrior : IEnemyFactory
{
    public IWeapon GetWeapon()
    {
        return new Sword();
    }

    public IAmor GetAmor()
    {
        return new BodyArmor();
    }
}

public class Mage : IEnemyFactory
{
    public IWeapon GetWeapon()
    {
        return new Wand();
    }

    public IAmor GetAmor()
    {
        return new Cloak();
    }
}

class Client
{
    IEnemyFactory factory = null;

    public void SpawnEnemy(string enemy)
    {
        switch (enemy)
        {
            case "Warrior":
                factory = new Warrior();
                Console.WriteLine(factory.GetWeapon().Item());
                Console.WriteLine(factory.GetAmor().Item());
                break;
            case "Mage":
                factory = new Mage();
                Console.WriteLine(factory.GetWeapon().Item());
                Console.WriteLine(factory.GetAmor().Item());
                break;
            default:
                Console.WriteLine("Wrong Type");
                break;
        }
    }

    static void Main(string[] args)
    {
        Client client = new Client();
        client.SpawnEnemy("Mage");
        client.SpawnEnemy("Warrior");
    }
}