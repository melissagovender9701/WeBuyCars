using System;
using System.Collections.Generic;
using System.Text;

namespace WeBuyCars.DataAccessLayer
{
    public class Model
    {
        public static int ModelId { get; set; }
        public static string ModelName { get; set; }
        public static int  MakeId {get;set;}
        public static string MakeName { get; set; }


        public static VehicleType VehicleType { get; set; }
        public Model(int id, string modelName, int makeId, string makeName, VehicleType vehicleType)
        {
            ModelId = id;
            ModelName = modelName;
            MakeId = makeId;
            MakeName = makeName;
            VehicleType = vehicleType;
        }

        public static void Display()
        {
            Console.WriteLine(ModelId +"-"+ MakeName +"-"+ModelName);
        }
    }
}
