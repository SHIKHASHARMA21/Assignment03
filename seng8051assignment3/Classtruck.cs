using System;

public class Truck : Vehicle
{
    private string capacity;
    private string truckType;
    private bool fourWheelDrive;

    public string Capacity
    {
        get { return capacity; }
        set { capacity = value; }
    }

    public string TruckType
    {
        get { return truckType; }
        set { truckType = value; }
    }

    public bool FourWheelDrive
    {
        get { return fourWheelDrive; }
        set { fourWheelDrive = value; }
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Capacity: " + Capacity);
        Console.WriteLine("Truck Type: " + TruckType);
        Console.WriteLine("Four Wheel Drive: " + FourWheelDrive);
    }
}
