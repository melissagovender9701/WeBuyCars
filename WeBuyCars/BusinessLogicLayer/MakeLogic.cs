using System;
using System.Collections.Generic;
using System.Text;
using WeBuyCars.DataAccessLayer;

namespace WeBuyCars.BusinessLogicLayer
{
    public class MakeLogic
    {
        public static List<Make> MakeList = GetMakes();
        public MakeLogic()
        {

        }
        public static List<Make> GetMakes()
        {
            MakeList = new List<Make>()
            {
                new Make(1,"Toyota"),
                new Make(2,"Nissan"),
                new Make(3,"Volkswagen")
            };
            return MakeList;
        }

        public static string GetMake(int makeId)
        {
            foreach(var item in MakeList)
            {
                if (Make.MakeId == makeId)
                {
                    return Make.MakeName;
                }
            }
            return "";
        }
    }
}
