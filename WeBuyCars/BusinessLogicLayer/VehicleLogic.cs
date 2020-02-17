using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeBuyCars.DataAccessLayer;

namespace WeBuyCars.BusinessLogicLayer
{
    public class VehicleLogic
    {
        public static List<Vehicle> Vehicle { get; set; }
        public static List<Bracket> SmallVehicleMillegeBracket { get; set; }
        public static List<Bracket> BigVehicleMillegeBracket { get; set; }
        public static List<Bracket> SmallVehicleYearBracket { get; set; }
        public static List<Bracket> BigVehicleYearBracket { get; set; }
        public static List<EnumDisplay> VehicleTypeList { get; set; }

        public VehicleLogic()
        {
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

        public static double GetPriceForSmallVehicleMillege()
        {
            var _vehicle = new Vehicle();
            foreach (var smallVehicleMillege in SmallVehicleMillegeBracket)
            {
                if (_vehicle.VehicleMillege > smallVehicleMillege.Minimum && _vehicle.VehicleMillege <= smallVehicleMillege.Maximum && _vehicle.VehicleType.Equals(VehicleType.Car))
                {
                    return _vehicle.VehicleBookValue * smallVehicleMillege.Percentage;
                }
            }
            return 0;
        }
        public double GetPriceForBigVehicleMillege()
        {
            var _vehicle = new Vehicle();
            foreach (var bigVehicleMillege in BigVehicleMillegeBracket)
            {
                if (_vehicle.VehicleMillege > bigVehicleMillege.Minimum && _vehicle.VehicleMillege <= bigVehicleMillege.Maximum && _vehicle.VehicleType.Equals(VehicleType.Truck))
                {
                    return _vehicle.VehicleBookValue * bigVehicleMillege.Percentage;
                }
            }
            return 0;
        }

        public double GetPriceForSmallVehicleYear()
        {
            var _vehicle = new Vehicle();
            foreach (var smallVehicleYear in SmallVehicleYearBracket)
            {
                if (Convert.ToInt32(_vehicle.VehicleYear) >= smallVehicleYear.Minimum && Convert.ToInt32(_vehicle.VehicleYear) <= smallVehicleYear.Maximum && _vehicle.VehicleType.Equals(VehicleType.Car))
                {
                    return _vehicle.VehicleBookValue * smallVehicleYear.Percentage;
                }
            }
            return 0;
        }

        public double GetPriceForBigVehicleYear()
        {
            var _vehicle = new Vehicle();
            foreach (var bigVehicleYear in BigVehicleYearBracket)
            {
                if (Convert.ToInt32(_vehicle.VehicleYear) >= bigVehicleYear.Minimum && Convert.ToInt32(_vehicle.VehicleYear) <= bigVehicleYear.Maximum && _vehicle.VehicleType.Equals(VehicleType.Car))
                {
                    return _vehicle.VehicleBookValue * bigVehicleYear.Percentage;
                }
            }
            return 0;
        }
    }
}
