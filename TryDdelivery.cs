using System;

namespace ConsoleApp1;

public class TryDdelivery
{

    public static void Main(String[] args)
    {

        //בדיקה אם יש סוללה מתחת ל30 הפעולה תעבוד או לא (לא אמורה לעבוד) 
        DeliveryDrone[] drones = new DeliveryDrone[3];
        DeliveryDrone drone1 = new DeliveryDrone("dro1", 5.0);
        drone1.BatteryPercentage = 25;
        drones[0] = drone1;



        //  בודקת אם זה נותן לי ליצור רחפן תקין
        DeliveryDrone drone2 = new DeliveryDrone("dro2", 10);
        drones[1] = drone2;

        //  רחפן עם משקל קטן, אבל לא מספיק סוללה  למשלוח
        DeliveryDrone drone3 = new DeliveryDrone("D3", 2);
        drone3.BatteryPercentage = 50; // 
        drones[2] = drone3;

        System.Console.WriteLine(drones[0]);
        for (int i = 0; i < drones.Length; i++)
        {
            System.Console.WriteLine(drones[i]);
        }

    }
    public static void Main2(String[] args)
    {
        //בדיקה אם יש סוללה מתחת ל30 הפעולה תעבוד או לא (לא אמורה לעבוד) 
        DeliveryDrone[] drones = new DeliveryDrone[3];
        DeliveryDrone drone1 = new DeliveryDrone("dro1", 5.0);
        drone1.BatteryPercentage = 25;
        drones[0] = drone1;



        //  בודקת אם זה נותן לי ליצור רחפן תקין
        DeliveryDrone drone2 = new DeliveryDrone("dro2", 10);
        drones[1] = drone2;

        //  רחפן עם משקל קטן, אבל לא מספיק סוללה  למשלוח
        DeliveryDrone drone3 = new DeliveryDrone("D3", 2);
        drone3.BatteryPercentage = 50; // 
        drones[2] = drone3;

        for (int i = 0; i < drones.Length; i++)
        {
            //להמריא
            DeliveryDrone drone = drones[i];
            DeliveryDrone.DeliveryResult TakeoffResult = drone.TakeOff();
            System.Console.WriteLine(TakeoffResult);

            //ניסיון לשלוח משלוח
            try
            {
                DeliveryDrone.DeliveryResult deliveryResult = drone.AssignDelivery(2, 15);
                System.Console.WriteLine(deliveryResult);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message+"there is a problem");
            }

            //נסיון לנחות
            try
            {
                drone.Land();
                System.Console.WriteLine("succeded");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message+"there is a problem");
                
            }
            

        }
        
    }




}
