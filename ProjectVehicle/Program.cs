using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            int vehicleSpeed = 0;
            int choice = 0;
            Vehicle objVehicle = new Vehicle("Cyber");

            while (choice != 4)
            {
                Console.WriteLine("Check Max Speed Limit On Road");
                Console.WriteLine("1:Enter Car Details");
                Console.WriteLine("2:Enter Speed");
                Console.WriteLine("3:Stop ");
                Console.WriteLine("4:Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Color of your vehicle: ");
                        objVehicle.Color = Console.ReadLine();
                        Console.WriteLine("Enter Number of Wheels of your vehicle: ");
                        objVehicle.NoOfWheels = int.Parse(Console.ReadLine());
                        objVehicle.Start();
                        break;
                    case 2:
                        Console.WriteLine("Enter your speed: ");
                        vehicleSpeed = int.Parse(Console.ReadLine());
                        objVehicle.SpeedUp(vehicleSpeed);
                        break;
                    case 3:
                        objVehicle.Stop();
                        break;
                    default:
                        Console.WriteLine("Choose Correct Option");
                        break;
                }
            }
        }
    }
}
