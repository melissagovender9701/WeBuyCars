using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeBuyCars.DataAccessLayer;

namespace WeBuyCars.BusinessLogicLayer
{
    public class DisplayLogic
    {
        public static string Answer { get; set; }
        public static void Start()
        {
            Console.WriteLine("*********************************We Buy Cars - 'Melissa's Version'*********************************");
            DisplayBuyOrSell();
        }

        public static void DisplayBuyOrSell()
        {
            int value;
            Console.WriteLine("Would you like to:\n1 - BUY A CAR\n2 - SELL A CAR");
            Answer = Console.ReadLine();
            while (!int.TryParse(Answer, out value) || !Answer.Equals("1") && !Answer.Equals("2") && Answer != null)
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                Answer = Console.ReadLine();
            }
            if (Answer.Equals("1"))
            {
                Console.WriteLine("Buy car");
            }
            else if (Answer.Equals("2"))
            {
                Console.WriteLine("Sell a car");
            }
        }

        public static void DisplayVehicleType()
        {
            int value;
            var VehicleTypeList = Enum.GetValues(typeof(VehicleType))
               .Cast<VehicleType>()
               .Select(t => new EnumDisplay
               {
                   EnumId = ((int)t + 1),
                   EnumName = t.ToString()
               });
            Console.WriteLine("What is the Vehicle Type?\nPlease enter the code for the type of vehicle:");
            foreach (var vehicleTypeList in VehicleTypeList)
            {
                Console.WriteLine(Convert.ToString(vehicleTypeList.EnumId) + "-" + vehicleTypeList.EnumName);
            }
            Answer = Console.ReadLine();
            while (!int.TryParse(Answer, out value) || !Answer.Equals("1") && !Answer.Equals("2") && !Answer.Equals("3") && Answer != null)
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                Answer = Console.ReadLine();
            }
        }

        public static void DisplaySmallVehicleServiceHistory()
        {
            int value;
            int count = 1;
            var SmallVehicleServiceHistoryList = Enum.GetValues(typeof(SmallVehicleServiceHistory))
               .Cast<SmallVehicleServiceHistory>()
               .Select(t => new EnumDisplay
               {
                   EnumId = (count++),
                   EnumName = t.ToString()
               });
            Console.WriteLine("\nPlease enter the code for the type of vehicle service history:");
            foreach (var smallVehicleServiceHistoryList in SmallVehicleServiceHistoryList)
            {
                Console.WriteLine(Convert.ToString(smallVehicleServiceHistoryList.EnumId) + "-" + smallVehicleServiceHistoryList.EnumName);
            }
        }

        public static void DisplayBigSmallVehicleServiceHistory()
        {
            int count = 1;
            var BigVehicleServiceHistoryList = Enum.GetValues(typeof(BigVehicleServiceHistory))
               .Cast<BigVehicleServiceHistory>()
               .Select(t => new EnumDisplay
               {
                   EnumId = (count++),
                   EnumName = t.ToString()
               });
            Console.WriteLine("\nPlease enter the code for the type of vehicle service history:");
            foreach (var bigVehicleServiceHistoryList in BigVehicleServiceHistoryList)
            {
                Console.WriteLine(Convert.ToString(bigVehicleServiceHistoryList.EnumId) + "-" + bigVehicleServiceHistoryList.EnumName);
            }
        }

        public static void DisplayVehicleSpecs()
        {
            int count = 1;
            var VehicleSpecsList = Enum.GetValues(typeof(VehicleSpecs))
               .Cast<VehicleSpecs>()
               .Select(t => new EnumDisplay
               {
                   EnumId = (count++),
                   EnumName = t.ToString()
               });
            Console.WriteLine("\nPlease enter the code for the type of vehicle service history:");
            foreach (var vehicleSpecsList in VehicleSpecsList)
            {
                Console.WriteLine(Convert.ToString(vehicleSpecsList.EnumId) + "-" + vehicleSpecsList.EnumName);
            }
        }

        public static void DisplayVehicleColour()
        {
            int count = 1;
            var VehicleColourList = Enum.GetValues(typeof(VehicleColour))
               .Cast<VehicleColour>()
               .Select(t => new EnumDisplay
               {
                   EnumId = (count++),
                   EnumName = t.ToString()
               });
            Console.WriteLine("\nPlease enter the code for the type of vehicle service history:");
            foreach (var vehicleColourList in VehicleColourList)
            {
                Console.WriteLine(Convert.ToString(vehicleColourList.EnumId) + "-" + vehicleColourList.EnumName);
            }
        }
    }
}
