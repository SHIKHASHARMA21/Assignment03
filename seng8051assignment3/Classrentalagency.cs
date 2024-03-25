using System;

public class RentalAgency
{
    private Vehicle[] fleet;
    private decimal totalRevenue;

    public RentalAgency(int capacity)
    {
        fleet = new Vehicle[capacity];
        totalRevenue = 0;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < fleet.Length; i++)
        {
            if (fleet[i] == null)
            {
                fleet[i] = vehicle;
                break;
            }
        }
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < fleet.Length; i++)
        {
            if (fleet[i] == vehicle)
            {
                fleet[i] = null;
                break;
            }
        }
    }

    public void RentVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < fleet.Length; i++)
        {
            if (fleet[i] == vehicle)
            {
                fleet[i] = null;
                totalRevenue += vehicle.RentalPrice;
                break;
            }
        }
    }

    public decimal TotalRevenue
    {
        get { return totalRevenue; }
    }
}
