using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeBuyCars.DataAccessLayer;

namespace WeBuyCars.BusinessLogicLayer
{
    public class DisplayLogic
    {
        private static int _vehicleType = 0;
        private static int _vehicleMake = 0;
        private static int _vehicleModel = 0;
        private static int _vehicleMillege = 0;
        private static int _vehicleSpec = 0;
        private static int _vehicleColour = 0;
        private static int _vehicleServiceHistory = 0;
        private static int _vehicleYear = 0;
        private static double _vehicleBookValue = 0;

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
            // vehicle = new VehicleLogic(_vehicleType, _vehicleSpec, _vehicleMillege, _vehicleColour, _vehicleServiceHistory-_vehicleBookValue, _vehicleYear);
        }

        public static void GetVehicleTypes()
        {
            ModelLogic.GetVehicleType();
            var _vehicleId = Console.ReadLine();
            while (!int.TryParse(_vehicleId, out _vehicleType))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _vehicleId = Console.ReadLine();
            }
        }

        public static void GetVehicleMakes()
        {
            ModelLogic.GetMakeFromVehicleType(_vehicleType);
            var _makeId = Console.ReadLine();
            while (!int.TryParse(_makeId, out _vehicleMake))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _makeId = Console.ReadLine();
            }
        }

        public static void GetVehicleModels()
        {
            ModelLogic.GetModelsFromMake(_vehicleType, _vehicleMake);
            var _modelId = Console.ReadLine();
            while (!int.TryParse(_modelId, out _vehicleModel))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _modelId = Console.ReadLine();
            }
        }

        public static void GetVehicleMillege()
        {
            Console.WriteLine("\nEnter the Millege of the vehicle: ");
            var _millege = Console.ReadLine();
            while(!int.TryParse(_millege, out _vehicleMillege))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _millege = Console.ReadLine();
            }
        }

        public static void GetVehicleSpecs()
        {
            Console.WriteLine("\nWhat is the spec of the vehicle?\nPlease enter the code below:");
            VehicleLogic.DisplaySpecs();
            var _specs = Console.ReadLine();
            while(!int.TryParse(_specs, out _vehicleSpec))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _specs = Console.ReadLine();
            }
        }

        public static void GetVehicleColour()
        {
            Console.WriteLine($"\nWhat is the colour of the vehicle?\nPlease enter the code below:");
            VehicleLogic.DisplayColour();
            var _colour = Console.ReadLine();
            while (!int.TryParse(_colour, out _vehicleColour))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _colour = Console.ReadLine();
            }
        }

        public static void GetVehicleServiceHistory()
        {
            Console.WriteLine($"\nWhat is the type of service history?\nPlease enter the code below:");
            VehicleLogic.DisplayServiceHistory();
            var _serviceHistory = Console.ReadLine();
            while (!int.TryParse(_serviceHistory, out _vehicleServiceHistory))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _serviceHistory = Console.ReadLine();
            }
        }

        public static void GetVehiclYear()
        {
            Console.WriteLine("\nEnter the year of the vehicle: ");
            var _year = Console.ReadLine();
            while (!int.TryParse(_year, out _vehicleYear))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _year = Console.ReadLine();
            }
        }

        public static void GetBookValue()
        {
            Console.WriteLine("\nEnter the book value of the vehicle: ");
            var _bookValue = Console.ReadLine();
            while (!double.TryParse(_bookValue, out _vehicleBookValue))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                _bookValue = Console.ReadLine();
            }
        }
    }
}
