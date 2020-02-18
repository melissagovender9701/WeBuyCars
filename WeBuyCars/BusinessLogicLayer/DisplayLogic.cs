using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeBuyCars.DataAccessLayer;

namespace WeBuyCars.BusinessLogicLayer
{
    public class DisplayLogic
    {
        public static void Start()
        {
            Console.WriteLine("*********************************We Buy Cars - 'Melissa's Version'*********************************");
            DisplayVehicleType();
        }

        public static void DisplayVehicleType()
        {
            int count = 0;
            int value;
            Array typenames;
            Console.WriteLine("What is the Vehicle Type?\nPlease enter the code below:");
            typenames = Enum.GetNames(typeof(VehicleType));
            for (int i = 0; i < typenames.Length; i++)
            {
                Console.WriteLine($"({i+1}) : {typenames.GetValue(i)}");
            }
            var vehicleId = Console.ReadLine();
           
            while (!int.TryParse(vehicleId, out value) || Enum.IsDefined(typeof(VehicleType), vehicleId) && vehicleId != null)
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                vehicleId = Console.ReadLine();
            }

            //Console.WriteLine("\nWhat is the Vehicle Make?\nPlease enter the code below:");
            //foreach (var makeList in MakeLogic.MakeList)
            //{
            //    count++;
            //    Console.WriteLine($"({makeList.MakeId}) : {makeList.MakeName}");
            //}
            //int vehicleMake = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWhat is the Vehicle Model?\nPlease enter the code below:");

            foreach (var modelList in ModelLogic.ModelList)
            {

                if (vehicleId.Equals(Enum.GetValues(typeof(VehicleType))))
                {
                    count++;
                    Model.Display();
                    //Console.WriteLine($"({modelList.ModelId}) : {modelList.MakeName} {modelList.ModelName}");
                }
            }
            int vehicleModel = Convert.ToInt32(Console.ReadLine());

            //foreach (var kk in ModelList)
            //{
            //    if (kk.enumid == choice)
            //    {

            //        kk.Display();
            //    }
            //}
            //foreach (var modelList in ModelLogic.ModelList)
            //{
            //    if (modelList.enumid == vehicleMake)
            //    {
            //        modelList.Display();
            //    }
            //}
        }
    }
}
