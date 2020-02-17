using System;
using System.Collections.Generic;
using System.Text;

namespace WeBuyCars.DataAccessLayer
{
    public class Model
    {
        public static int ModelId { get; set; }
        public static string ModelName { get; set; }

        public Model(int id, string modelName)
        {
            ModelId = id;
            ModelName = modelName;
        }
    }
}
