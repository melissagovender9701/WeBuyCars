using System;
using System.Collections.Generic;
using System.Text;

namespace WeBuyCars.DataAccessLayer
{
    public class Bracket
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public double Percentage { get; set; }

        public Bracket()
        {

        }

        public Bracket(int minimum, int maximum, double percentage)
        {
            Minimum = minimum;
            Maximum = maximum;
            Percentage = percentage;
        }
    }
}
