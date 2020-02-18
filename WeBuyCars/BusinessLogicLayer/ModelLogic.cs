using System;
using System.Collections.Generic;
using System.Text;
using WeBuyCars.DataAccessLayer;

namespace WeBuyCars.BusinessLogicLayer
{
    public class ModelLogic
    {
        public static List<Model> ModelList = GetModels();

        public ModelLogic()
        {

        }

        public static List<Model> GetModels()
        {
            ModelList = new List<Model>()
            {
                new Model (1, "Supra", 1, "Toyota", VehicleType.Car),
                new Model (2, "86", 1, "Toyota", VehicleType.Car),
                new Model (3, "GTR", 2, "Nissan", VehicleType.Car),
                new Model (4, "Polo", 3, "Volkswagen",VehicleType.Car),
                new Model (5, "Daseries", 1, "Toyota",VehicleType.Truck),
                new Model (6, "Hino", 1, "Toyota",VehicleType.Bus),
            };
            return ModelList;
        }
        public static void GetVehicleType()
        {
            Array typeNames;

            Console.WriteLine("\nWhat is the vehicle type?\nPlease enter the code below:");
            typeNames = Enum.GetNames(typeof(VehicleType));
            for (int i = 0; i < typeNames.Length; i++)
            {
                Console.WriteLine($"({i + 1}) : {typeNames.GetValue(i)}");
            }
        }

        public static void GetMakeFromVehicleType(int vehicleType)
        {
            Console.WriteLine("\nWhat is the vehicle make?\nPlease enter the code below:");
            foreach (var makeList in MakeLogic.MakeList)
            {
                foreach (int i in Enum.GetValues(typeof(VehicleType)))
                {
                    if (i.Equals(vehicleType))
                    {
                        Console.WriteLine($"({makeList.MakeId}) : {makeList.MakeName}");
                    }
                }
            }
        }

        public static void GetModelsFromMake(int vehicleType, int makeId)
        {
            Console.WriteLine("\nWhat is the vehicle model?\nPlease enter the code below:");
            foreach (var modelList in ModelList)
            {
                foreach (int i in Enum.GetValues(typeof(VehicleType)))
                {
                    if (modelList.MakeId.Equals(makeId) && i.Equals(vehicleType))
                    {
                        Console.WriteLine($"({modelList.ModelId}) : {modelList.MakeName} {modelList.ModelName}");
                    }
                }
            }
        }
    }
}

