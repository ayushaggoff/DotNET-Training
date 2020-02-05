using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVehicle
{
    class Vehicle1
    {
        private string vehicleName;
        public const int MaxSpeed = 60;
        private string _vehicleColor;
        private int _noOfWheels;
        public Vehicle1(string vehicleName)
        {
            this.vehicleName = vehicleName;
        }
        public string Color
        {
            get { return _vehicleColor; }
            set { _vehicleColor = value; }
        }
        public int NoOfWheels
        {
            get { return _noOfWheels; }
            set { _noOfWheels = value; }
        }
        public void Start()
        {
            Console.WriteLine("Your Vehicle " + vehicleName + " " + _noOfWheels + " of color " + _vehicleColor + " has Started");
            Console.WriteLine("where Vehicle Name:" + vehicleName + ", Number of Wheels:" + _noOfWheels + ",Color:" + _vehicleColor);
            Console.ReadKey();
        }
        public void Stop()
        {
            Console.WriteLine("Your Vehicle " + vehicleName + " " + _noOfWheels + " of color " + _vehicleColor + " has Stoped");
            Console.ReadKey();
        }
        /// <summary>
        /// SpeedUp method take Vehicle Speed entered by the user
        /// </summary>
        /// <param name="vehicleSpeed"></param>
        public void SpeedUp(int vehicleSpeed)
        {
            if (vehicleSpeed > MaxSpeed)
            {
                Console.WriteLine("You have crossed the " + MaxSpeed + " limit");
                Console.WriteLine("Your Vehicle " + vehicleName + " " + _noOfWheels + " of color " + _vehicleColor + "speeds up to " + MaxSpeed);
                Console.Write(".where Vehicle Name:" + vehicleName + ", Number of Wheels:" + _noOfWheels + ",Color:" + _vehicleColor + " & " + vehicleSpeed + " is vehicle speed");
            }
            else
            {
                Console.WriteLine("Your " + vehicleSpeed + " is underlimit");
                Console.WriteLine("Max speed allowed:" + MaxSpeed);
                Console.WriteLine("Your Vehicle " + vehicleName + " " + _noOfWheels + " of color " + _vehicleColor + "speeds up to " + MaxSpeed);
                Console.Write(".where Vehicle Name:" + vehicleName + ", Number of Wheels:" + _noOfWheels + ",Color:" + _vehicleColor + " & " + vehicleSpeed + " is vehicle speed");
            }
            Console.ReadKey();
        }
    }
}

