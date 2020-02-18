using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeBuyCars.DataAccessLayer;

namespace WeBuyCars.BusinessLogicLayer
{
    public class VehicleLogic
    {
        public static List<Vehicle> VehicleList { get; set; }
        public static List<Bracket> SmallVehicleMillegeBracket { get; set; }
        public static List<Bracket> BigVehicleMillegeBracket { get; set; }
        public static List<Bracket> SmallVehicleYearBracket { get; set; }
        public static List<Bracket> BigVehicleYearBracket { get; set; }

        public VehicleLogic()
        {
            VehicleList = new List<Vehicle>()
            {
                new Vehicle(VehicleType.Car, 2012, 160000, VehicleServiceHistory.LowServiceHistory,VehicleColour.Metallic,VehicleSpecs.HighSpec, 200000,2),
                new Vehicle(VehicleType.Car, 2012, 160000, VehicleServiceHistory.LowServiceHistory,VehicleColour.Metallic,VehicleSpecs.HighSpec, 200000,2),
                new Vehicle(VehicleType.Car, 2012, 160000, VehicleServiceHistory.LowServiceHistory,VehicleColour.Metallic,VehicleSpecs.HighSpec, 200000,2),
                new Vehicle(VehicleType.Car, 2012, 160000, VehicleServiceHistory.LowServiceHistory,VehicleColour.Metallic,VehicleSpecs.HighSpec, 200000,2)       
            };

            SmallVehicleMillegeBracket = new List<Bracket>()
            {
                new Bracket(int.MinValue, 100000, 0.30),
                new Bracket(100000, 150000, 0.20),
                new Bracket(150000, int.MaxValue, 0.15)
            };

            BigVehicleMillegeBracket = new List<Bracket>()
            {
                new Bracket(int.MinValue, 100000, 0.40),
                new Bracket(100000, 150000, 0.30),
                new Bracket(150000, int.MaxValue, 0.20)
            };

            SmallVehicleYearBracket = new List<Bracket>()
            {
                new Bracket(2011, 2011, 0.10),
                new Bracket(2012, 2018, 0.20),
                new Bracket(2019, 2019, 0.30)
            };

            BigVehicleYearBracket = new List<Bracket>()
            {
                new Bracket(2011, 2011, 0.20),
                new Bracket(2012, 2018, 0.30),
                new Bracket(2019, 2019, 0.40)
            };
        }

      


        public static double GetPriceForSmallVehicleMillege(Vehicle vehicle)
        {
            foreach (var smallVehicleMillege in SmallVehicleMillegeBracket)
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
            foreach (var bigVehicleMillege in BigVehicleMillegeBracket)
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
            foreach (var smallVehicleYear in SmallVehicleYearBracket)
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
            foreach (var bigVehicleYear in BigVehicleYearBracket)
            {
                if (Convert.ToInt32(vehicle.VehicleYear) >= bigVehicleYear.Minimum && Convert.ToInt32(vehicle.VehicleYear) <= bigVehicleYear.Maximum && vehicle.VehicleType.Equals(VehicleType.Car))
                {
                    return vehicle.VehicleBookValue * bigVehicleYear.Percentage;
                }
            }
            return 0;
        }

        //public static double GetSellingPrice()
        //{
        //    if (VehicleType.Car.Equals(Enum.GetNames(VehicleType)){

        //    }
        //    return 0;
        //}
    }
}
