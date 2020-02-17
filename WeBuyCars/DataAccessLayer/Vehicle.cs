using System;
using System.Collections.Generic;
using System.Text;

namespace WeBuyCars.DataAccessLayer
{
    public enum SmallVehicleServiceHistory
    {
        FullServiceHistory = 40,
        MediumServiceHistory = 30,
        LowServiceHistory = 0
    }

    public enum BigVehicleServiceHistory
    {
        FullServiceHistory = 55,
        MediumServiceHistory = 40,
        LowServiceHistory = 0
    }

    public enum TypesofVehicleSpecs
    {
        HighSpec = 30,
        MediumSpec = 15,
        LowSpec = 0
    }

    public enum VehicleColour
    {
        Metallic = 5000,
        Flat = 0
    }
    public class Vehicle
    {
        public List<string> VehicleType { get; set; }
        public Make VehicleMake { get; set; }
        public Model VehicleModel { get; set; }
        public DateTime VehicleYear { get; set; }
        public int VehicleMillege { get; set; }
        public List<string> VehicleServiceHistory { get; set; }
        public List<string> VehicleColor { get; set; }
        public List<string> VehicleSpecs { get; set; }
        public double VehicleBookValue { get; set; }

        public Vehicle()
        {
            VehicleType = new List<string>() { "Car", "Bus", "Truck"};
        }

        public Vehicle(List<string> vehicletype, Make vehiclemake, Model vehiclemodel, DateTime vehicleyear, int vehiclemillege, List<string> vehicleservicehistory, List<string> vehiclecolor, List<string> vehiclespecs, double vehiclebookvalue)
        {
            VehicleType = vehicletype;
            VehicleMake = vehiclemake;
            VehicleModel = vehiclemodel;
            VehicleYear = vehicleyear;
            VehicleMillege = vehiclemillege;
            VehicleServiceHistory = vehicleservicehistory;
            VehicleColor = vehiclecolor;
            VehicleSpecs = vehiclespecs;
            VehicleBookValue = vehiclemillege;
        }

        public virtual double SellingPrice()
        {
            double _price = 0.00;
            return _price;
        }
    }
}
