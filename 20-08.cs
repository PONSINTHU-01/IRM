using System.Reflection;

interface iMaintenance
{
    public void service();

}
abstract class Vehicle
{
    public string Brand;
    public string Model;
    public string Speed;

    public  void display()
    {
        Console.WriteLine("This is vehicle ");
    }
    public virtual void StartEngine()
    {
        Console.WriteLine("The Engine has been started");
    }
    public abstract void Drive();

}
class Car : Vehicle,iMaintenance
{
    public int NO_Of_Doors;

    public Car(string brand, string model,string speed,int no_of_Doors)
    {
        Brand = brand;
        Model = model;  
        Speed = speed;
        NO_Of_Doors = no_of_Doors;
    }
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started");
    }
    public override void Drive()
    {
        Console.WriteLine("Driving a car with four wheels");
    }
    public void service()
    {
        Console.WriteLine("Car is under maintenance");
    }
}
class Bike : Vehicle,iMaintenance
{
    public bool HasGeer;

    public Bike(string brand, string model,string speed, bool hasGeer)
    {
        Brand= brand;
        Model = model;
        Speed = speed;
        HasGeer = hasGeer;
    }

    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started");
    }
    public override void Drive()
    {
        Console.WriteLine("Driving a bike with two wheels");
    }
    public void service()
    {
        Console.WriteLine("Bike is under maintenance");
    }
}

class program
{
    public static void Main(string[] args)
    {
        Vehicle c1=new Car("Toyota", "Corolla", "120km/h", 4);
        Vehicle b1 = new Bike("Yamaha","R15","80km/h",true);

        Console.WriteLine("********CAR********");
        c1.display();
        c1.StartEngine();
        c1.Drive();
        iMaintenance carMaintenance = new Car("Toyota", "Fortuner", "150km/h", 4);
        carMaintenance.service();

        Console.WriteLine();

        Console.WriteLine("********BIKE********");
        b1.display();
        b1.StartEngine();
        b1.Drive();

        iMaintenance bikeMaintenance = new Bike("Honda", "Shine", "60km/h", false);
        bikeMaintenance.service();
    }
}

