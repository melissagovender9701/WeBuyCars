using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeBuyCars.DataAccessLayer;

namespace WeBuyCars.BusinessLogicLayer
{
    public class DisplayLogic
    {
        private static string _vehicleType = "";
        private static string _vehicleMake = "";
        private static string _vehicleModel = "";
        private static string _vehicleMillege = "";
        private static string _vehicleSpec = "";
        private static string _vehicleColour = "";
        private static string _vehicleServiceHistory = "";
        private static string _vehicleYear = "";
        private static string _vehicleBookValue = "";
        private static int value = 0;

        private static Array VehicleTypesNames;
        private static Array vehicleSpecsNames;
        private static Array TypeColoursNames;
        private static Array TypeServiceHistoryNames;



        public static void Start()
        {
            Console.WriteLine("****************************************We Buy Cars - 'Melissa's Version'****************************************");
            GetVehicleTypes();
            GetVehicleMakes();
            GetVehicleModels();
            GetVehicleMillege();
            GetVehicleSpecs();
            GetVehicleColour();
            GetVehicleServiceHistory();
            GetVehiclYear();
            GetBookValue();
            

            var vehicle = new Vehicle((VehicleType)Enum.Parse(typeof(VehicleType), Convert.ToInt32(_vehicleType).ToString()), Convert.ToInt32(_vehicleYear), Convert.ToInt32(_vehicleMillege), (VehicleServiceHistory)Enum.Parse(typeof(VehicleServiceHistory), Convert.ToInt32(_vehicleServiceHistory).ToString()), (VehicleColour)Enum.Parse(typeof(VehicleColour), Convert.ToInt32(_vehicleColour).ToString()), (VehicleSpecs)Enum.Parse(typeof(VehicleSpecs), Convert.ToInt32(_vehicleSpec).ToString()), Convert.ToDouble(_vehicleBookValue));
            var vehicleLogic = new VehicleLogic();
            Console.WriteLine("\nTotal Cost :" + VehicleLogic.CalculateTotalCost(vehicle));
            Console.ReadKey();

        }

        public static void GetVehicleTypes()
        {
            Console.WriteLine("\nWhat is the vehicle type?\nPlease enter the code below:");
            VehicleTypesNames = Enum.GetNames(typeof(VehicleType));
            for (int i = 0; i < VehicleTypesNames.Length; i++)
            {
                Console.WriteLine($"({i + 1}) : {VehicleTypesNames.GetValue(i)}");
            }
            _vehicleType = Console.ReadLine();
            while (!int.TryParse(_vehicleType, out value) || Convert.ToInt32(_vehicleType) > Enum.GetValues(typeof(VehicleType)).Length || String.IsNullOrEmpty(_vehicleType))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _vehicleType = Console.ReadLine();
            }
        }

        public static void GetVehicleMakes()
        {
            ModelLogic.GetMakeFromVehicleType(Convert.ToInt32(_vehicleType));
            _vehicleMake = Console.ReadLine();
            while (!int.TryParse(_vehicleMake, out value) || Convert.ToInt32(_vehicleMake) > MakeLogic.MakeList.Count || String.IsNullOrEmpty(_vehicleMake))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _vehicleMake = Console.ReadLine();
            }
        }

        public static void GetVehicleModels()
        {
            ModelLogic.GetModelsFromMake(Convert.ToInt32(_vehicleType), Convert.ToInt32(_vehicleMake));
            _vehicleModel = Console.ReadLine();
            foreach(var list in ModelLogic.ModelList)
            {
                while (!int.TryParse(_vehicleModel, out value) || String.IsNullOrEmpty(_vehicleMake))
                {
                    Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                    _vehicleModel = Console.ReadLine();
                }
            }
           
        }

        public static void GetVehicleMillege()
        {
            Console.WriteLine("\nEnter the Millege of the vehicle: ");
            _vehicleMillege = Console.ReadLine();
                while (!int.TryParse(_vehicleMillege, out value) || Convert.ToInt32(_vehicleMillege) > 200000  || Convert.ToInt32(_vehicleMillege) < 100 || String.IsNullOrEmpty(_vehicleMake))
                {
                    Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                    _vehicleMillege = Console.ReadLine();
                }
        }

        public static void GetVehicleSpecs()
        {
            Console.WriteLine("\nWhat is the spec of the vehicle?\nPlease enter the code below:");
            vehicleSpecsNames = Enum.GetNames(typeof(VehicleSpecs));
            for (int i = 0; i < vehicleSpecsNames.Length; i++)
            {
                Console.WriteLine($"({i + 1}) : {vehicleSpecsNames.GetValue(i)}");
            }

            _vehicleSpec = Console.ReadLine();
            while (!int.TryParse(_vehicleSpec, out value) || Convert.ToInt32(_vehicleSpec) > Enum.GetValues(typeof(VehicleSpecs)).Length || String.IsNullOrEmpty(_vehicleSpec))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _vehicleSpec = Console.ReadLine();
            }
        }

        public static void GetVehicleColour()
        {
            Console.WriteLine($"\nWhat is the colour of the vehicle?\nPlease enter the code below:");

               
            TypeColoursNames = Enum.GetNames(typeof(VehicleColour));
                for (int i = 0; i < TypeColoursNames.Length; i++)
                {
                    Console.WriteLine($"({i + 1}) : {TypeColoursNames.GetValue(i)}");
                }

            _vehicleColour = Console.ReadLine();
            while (!int.TryParse(_vehicleColour, out value) || Convert.ToInt32(_vehicleColour) > Enum.GetValues(typeof(VehicleColour)).Length || String.IsNullOrEmpty(_vehicleColour))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _vehicleColour = Console.ReadLine();
            }
        }

        public static void GetVehicleServiceHistory()
        {
            Console.WriteLine($"\nWhat is the type of service history?\nPlease enter the code below:");
            TypeServiceHistoryNames = Enum.GetNames(typeof(VehicleServiceHistory));
                for (int i = 0; i < TypeServiceHistoryNames.Length; i++)
                {
                    Console.WriteLine($"({i + 1}) : {TypeServiceHistoryNames.GetValue(i)}");
                }
            _vehicleServiceHistory = Console.ReadLine();
            while (!int.TryParse(_vehicleServiceHistory, out value) || Convert.ToInt32(_vehicleServiceHistory) > Enum.GetValues(typeof(VehicleServiceHistory)).Length || String.IsNullOrEmpty(_vehicleServiceHistory))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _vehicleServiceHistory = Console.ReadLine();
            }
        }

        public static void GetVehiclYear()
        {
            Console.WriteLine("\nEnter the year of the vehicle: ");
            _vehicleYear = Console.ReadLine();
            while (!int.TryParse(_vehicleYear, out value) || Convert.ToInt32(_vehicleYear) > 2020 || Convert.ToInt32(_vehicleYear) < 1800 || String.IsNullOrEmpty(_vehicleYear))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _vehicleYear = Console.ReadLine();
            }
        }

        public static void GetBookValue()
        {
            double value;
            Console.WriteLine("\nEnter the book value of the vehicle: ");
            _vehicleBookValue = Console.ReadLine();
            while (!double.TryParse(_vehicleBookValue, out value))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _vehicleBookValue = Console.ReadLine();
            }
        }
    }
}
