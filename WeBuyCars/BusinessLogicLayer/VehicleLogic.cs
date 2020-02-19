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
        public static List<Bracket> VehicleMillegeBracket { get; set; }
        public static List<Bracket> AdditionalVehicleMillegeBracket { get; set; }
        public static List<Bracket> VehicleYearBracket { get; set; }
        public static List<Bracket> AdditionalVehicleYearBracket { get; set; }

        
        public VehicleLogic()
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
                new Bracket(1900, 2011, 0.10),
                new Bracket(2012, 2018, 0.20),
                new Bracket(2019, 2019, 0.30)
            };

            AdditionalVehicleYearBracket = new List<Bracket>()
            {
                new Bracket(1900, 2011, 0.20),
                new Bracket(2012, 2018, 0.30),
                new Bracket(2019, 2019, 0.40)
            };
        }

        public static  double CalculateServiceHistoryCost(Vehicle vehicle)
        {
           //Array typeValues;
            //typeValues = Enum.GetValues(typeof(VehicleServiceHistory));
            foreach (VehicleServiceHistory serviceHistory in Enum.GetValues(typeof(VehicleServiceHistory)))
            {
                if (vehicle.Equals((int)serviceHistory))
                {
                    Console.WriteLine("yes");
                    return vehicle.VehicleBookValue * ((int)serviceHistory / 100);
                }
            }
            return 0;
        }

        public static double CalculateSpecsCost(Vehicle vehicle)
        {
            Array typeValues;
            typeValues = Enum.GetValues(typeof(VehicleSpecs));
            foreach (var vehicleSpecs in typeValues)
            {
                if (vehicle.Equals(vehicleSpecs))
                {
                    return vehicle.VehicleBookValue * (Convert.ToInt32(Enum.GetValues(typeof(VehicleSpecs))) / 100);
                }
            }
            return 0;
        }

        public static double CalculateMillegeCost(Vehicle vehicle)
        {
            foreach (var millegeBracket in VehicleLogic.VehicleMillegeBracket)
            {
                if (vehicle.VehicleMillege >= millegeBracket.Minimum && vehicle.VehicleMillege < millegeBracket.Maximum)
                {
                    foreach (var item in VehicleLogic.AdditionalVehicleMillegeBracket)
                    {
                        if (item.Maximum == millegeBracket.Maximum && item.Maximum.Equals(vehicle.VehicleType))
                        {
                            return millegeBracket.Percentage + millegeBracket.Percentage * item.Maximum;
                        }
                    }
                }
            }
            return 0;
        }

        public static double CalculateYearCost(Vehicle vehicle)
        {
            foreach (var yearBracket in VehicleLogic.VehicleYearBracket)
            {
                if (vehicle.VehicleYear >= yearBracket.Maximum && vehicle.VehicleYear < yearBracket.Minimum)
                {
                    foreach (var additionalYearBracket in VehicleLogic.AdditionalVehicleYearBracket)
                    {
                        if (yearBracket.Maximum == additionalYearBracket.Maximum && additionalYearBracket.Minimum.Equals(vehicle.VehicleType))
                        {
                            return (yearBracket.Percentage) + yearBracket.Percentage * additionalYearBracket.Maximum;
                        }
                    }
                }
            }
            return 0;
        }

        public static double CalculateColourCost(Vehicle vehicle)
        {
            Array typeValues;
            typeValues = Enum.GetValues(typeof(VehicleColour));
            foreach (var vehicleColour in typeValues)
            {
                if (vehicleColour.Equals(vehicle.VehicleColour))
                {
                    return vehicle.VehicleBookValue * (Convert.ToInt32(Enum.GetValues(typeof(VehicleColour))) / 100);
                }
            }
            return 0;
        }

        public static double CalculateTotalCost(Vehicle vehicle)
        {
            return vehicle.VehicleBookValue + CalculateServiceHistoryCost(vehicle) + CalculateSpecsCost(vehicle) + CalculateMillegeCost(vehicle) + CalculateYearCost(vehicle) + CalculateColourCost(vehicle);
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






        

    }
}
