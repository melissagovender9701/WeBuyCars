using System;
using System.Collections.Generic;
using System.Text;

namespace WeBuyCars.DataAccessLayer
{
    public class Model
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int  MakeId {get;set;}
        public string MakeName { get; set; }
        public VehicleType VehicleType { get; set; }

        public Model(int id, string modelName, int makeId, string makeName, VehicleType vehicleType)
        {
            ModelId = id;
            ModelName = modelName;
            MakeId = makeId;
            MakeName = makeName;
            VehicleType = vehicleType;
        }
    }
}
