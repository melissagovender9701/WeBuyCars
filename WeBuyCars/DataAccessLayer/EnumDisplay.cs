using System;
using System.Collections.Generic;
using System.Text;

namespace WeBuyCars.DataAccessLayer
{
    public class EnumDisplay
    {
        public int EnumId { get; set; }
        public string EnumName { get; set; }

        public EnumDisplay()
        {

        }

        public EnumDisplay(int enumId, string enumName)
        {
            EnumId = enumId;
            EnumName = enumName;
        }
    }
}
