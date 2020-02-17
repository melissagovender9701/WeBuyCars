using System;
using System.Collections.Generic;
using System.Text;

namespace WeBuyCars.DataAccessLayer
{
    public class Make
    {
        public int MakeId { get; set; }
        public string MakeName { get; set; }

        public Make()
        {

        }
        public Make(int makeId, string makeName)
        {
            MakeId = makeId;
            MakeName = makeName;
        }
    }
}
