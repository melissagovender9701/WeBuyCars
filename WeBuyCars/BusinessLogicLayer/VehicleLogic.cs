using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeBuyCars.DataAccessLayer;

namespace WeBuyCars.BusinessLogicLayer
{
    public class VehicleLogic : Vehicle
    {
        public static List<Vehicle> VehicleList { get; set; }
        public static List<Bracket> VehicleMillegeBracket { get; set; }
        public static List<Bracket> AdditionalVehicleMillegeBracket { get; set; }
        public static List<Bracket> VehicleYearBracket { get; set; }
        public static List<Bracket> AdditionalVehicleYearBracket { get; set; }

        
        public VehicleLogic(VehicleType vehicleType, VehicleSpecs specs, int millege, VehicleColour colour, VehicleServiceHistory serviceHistory, double bookValue, int year): base(vehicleType, year,millege,serviceHistory,colour,specs,bookValue)
        {
            VehicleMillegeBracket = new List<Bracket>()
            {
                new Bracket(int.MinValue, 100000, 0.30),
                new Bracket(100000, 150000, 0.20),
                new Bracket(150000, int.MaxValue, 0.15)
            };

            AdditionalVehicleMillegeBracket = new List<Bracket>()
            {
                new Bracket(int.MinValue, 100000, 0.40),
                new Bracket(100000, 150000, 0.30),
                new Bracket(150000, int.MaxValue, 0.20)
            };

            VehicleYearBracket = new List<Bracket>()
            {
                new Bracket(2011, 2011, 0.10),
                new Bracket(2012, 2018, 0.20),
                new Bracket(2019, 2019, 0.30)
            };

            AdditionalVehicleYearBracket = new List<Bracket>()
            {
                new Bracket(2011, 2011, 0.20),
                new Bracket(2012, 2018, 0.30),
                new Bracket(2019, 2019, 0.40)
            };
        }

        public double CalculateServiceHistoryCost()
        {
            return 0;
        }

        public double CalculateSpecsCost()
        {
            return 0;
        }

        public double CalculateMillegeCost()
        {
            return 0;
        }

        public double CalculateYearCost()
        {
            return 0;
        }

        public double CalculateColourCost()
        {
            return 0;
        }

        public double CalculateTotalCost()
        {
            return VehicleBookValue + CalculateServiceHistoryCost() + CalculateSpecsCost() + CalculateMillegeCost() + CalculateYearCost() + CalculateColourCost();
        }

        public static double GetPriceForSmallVehicleMillege(Vehicle vehicle)
        {
            foreach (var smallVehicleMillege in VehicleMillegeBracket)
            {
                if (vehicle.VehicleMillege > smallVehicleMillege.Minimum && vehicle.VehicleMillege <= smallVehicleMillege.Maximum && vehicle.VehicleType.Equals(VehicleType.Car))
                {
                    return vehicle.VehicleBookValue * smallVehicleMillege.Percentage;
                }
            }
            return 0;
        }

        public double GetPriceForBigVehicleMillege(Vehicle vehicle)
        {
            foreach (var bigVehicleMillege in AdditionalVehicleMillegeBracket)
            {
                if (vehicle.VehicleMillege > bigVehicleMillege.Minimum && vehicle.VehicleMillege <= bigVehicleMillege.Maximum && vehicle.VehicleType.Equals(VehicleType.Truck))
                {
                    return vehicle.VehicleBookValue * bigVehicleMillege.Percentage;
                }
            }
            return 0;
        }

        public double GetPriceForSmallVehicleYear(Vehicle vehicle)
        {
            foreach (var smallVehicleYear in VehicleYearBracket)
            {
                if (Convert.ToInt32(vehicle.VehicleYear) >= smallVehicleYear.Minimum && Convert.ToInt32(vehicle.VehicleYear) <= smallVehicleYear.Maximum && vehicle.VehicleType.Equals(VehicleType.Car))
                {
                    return vehicle.VehicleBookValue * smallVehicleYear.Percentage;
                }
            }
            return 0;
        }

        public double GetPriceForBigVehicleYear(Vehicle vehicle)
        {
            foreach (var bigVehicleYear in AdditionalVehicleYearBracket)
            {
                if (Convert.ToInt32(vehicle.VehicleYear) >= bigVehicleYear.Minimum && Convert.ToInt32(vehicle.VehicleYear) <= bigVehicleYear.Maximum && vehicle.VehicleType.Equals(VehicleType.Car))
                {
                    return vehicle.VehicleBookValue * bigVehicleYear.Percentage;
                }
            }
            return 0;
        }

        public static void DisplaySpecs()
        {
            Array typeNames;
            typeNames = Enum.GetNames(typeof(VehicleSpecs));
            for (int i = 0; i < typeNames.Length; i++)
            {
                Console.WriteLine($"({i + 1}) : {typeNames.GetValue(i)}");
            }
        }

        public static void DisplayColour()
        {
            Array typeNames;
            typeNames = Enum.GetNames(typeof(VehicleColour));
            for (int i = 0; i < typeNames.Length; i++) 
            {
                Console.WriteLine($"({i + 1}) : {typeNames.GetValue(i)}");
            }
        }

        public static void DisplayServiceHistory()
        {
            Array typeNames;
            typeNames = Enum.GetNames(typeof(VehicleServiceHistory));
            for (int i = 0; i < typeNames.Length; i++)
            {
                Console.WriteLine($"({i + 1}) : {typeNames.GetValue(i)}");
            }
        }

        

    }
}
