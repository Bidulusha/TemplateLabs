using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface IFactory
{
    void Drive(int kilometers);
}

public class Scooter : IFactory
{
    public void Drive(int kilometers)
    {
        //TODO
    }
}

public class Bike : IFactory
{
    public void Drive(int kilometers)
    {
        //TODO
    }
}

public abstract class VehicleFactory
{
    public abstract IFactory GetVehicle(string Vehicle);
}

public class ConcreteVehicleFactory : VehicleFactory
{
    public override IFactory GetVehicle(string Vehicle)
    {
        switch (Vehicle)
        {
            case "Scooter":
                return new Scooter();
            case "Bike":
                return new Bike();
            default:
                throw new ApplicationException(string.Format("Vehicle {0} cannot be created", Vehicle));
        }

    }
}

public class BasicCalculatorSwitch
{
    public static void Main(string[] args)
    {
        VehicleFactory factory = new ConcreteVehicleFactory();
        IFactory scooter = factory.GetVehicle("Scooter");
        scooter.Drive(10);

        IFactory bike = factory.GetVehicle("Bike");
        bike.Drive(20);
    }
}