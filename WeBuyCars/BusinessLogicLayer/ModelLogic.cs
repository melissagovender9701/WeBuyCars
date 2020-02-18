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
      

    }
}
