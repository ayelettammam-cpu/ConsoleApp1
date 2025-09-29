using System;

namespace ConsoleApp1;

public class DeliveryDrone
{
    public string Id { get; }
    public double MaxWeightKg { get; }
    public double BatteryPercentage { get; set; }
    public int CurrentAltitude { get; private set; }
    public string Status { get; private set; }

    public DeliveryDrone(string id, double maxWeightCapacity)
    {
        if (id == null || id == "")
        {
            throw new ArgumentNullException("Initial cannot be empty");
        }
        if (maxWeightCapacity <= 0)
        {
            throw new ArgumentOutOfRangeException("Initial balance cannot be nagitive or zero");
        }
        MaxWeightKg = maxWeightCapacity;
        BatteryPercentage = 100;
        CurrentAltitude = 0;
        Status = "Grounded";
        
    }


    
    public DeliveryResult TakeOff()
    {
        if (BatteryPercentage < 30)
        {
            return DeliveryResult.Failure;
        }
        if (Status != "Grounded")
        {
            throw new InvalidOperationException("cnoot do that while flying");
        }
        else
        {
            CurrentAltitude = 50;
            Status = "inFlight";
            return DeliveryResult.Success;

        }
    }

    public DeliveryResult AssignDelivery(double packageWeight, int distanceKm)
    {
        if (packageWeight > MaxWeightKg || distanceKm*5 > CurrentAltitude)
        {
            return DeliveryResult.Failure;
        }
        if (Status != "inFlight")
        {
            throw new InvalidOperationException("cannot");
        }
        else
        {
            BatteryPercentage -= distanceKm;
            Status = "ReturningHome";
            return DeliveryResult.Success;
        }
    }
    public void Land()
    {
        if (Status != "ReturningHome")
        {
            throw new InvalidOperationException("cannot");
        }
    
            CurrentAltitude = 0;
            Status = "Grounded";
    
     }
    public enum DeliveryResult
    {
        Failure,
        Success
    }
}


