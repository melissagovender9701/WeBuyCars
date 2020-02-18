using System;
using System.Collections.Generic;
using System.Text;

namespace WeBuyCars.DataAccessLayer
{
    public enum VehicleType
    {
        Car=1,
        Truck=2,
        Bus=3
    }

    public enum VehicleServiceHistory
    {
        FullServiceHistory = 40,
        PartialServiceHistory = 30,
        LowServiceHistory = 0
    }

    public enum AdditionalVehicleServiceHistory
    {
        FullServiceHistory = 55,
        PartialServiceHistory = 40,
        LowServiceHistory = 0
    }

    public enum VehicleSpecs
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
        public VehicleType VehicleType { get; set; }
        public int VehicleYear { get; set; }
        public int VehicleMillege { get; set; }
        public VehicleServiceHistory VehicleServiceHistory { get; set; }
        public AdditionalVehicleServiceHistory AdditionalVehicleServiceHistory { get; set; }
        public VehicleColour VehicleColour { get; set; }
        public VehicleSpecs VehicleSpecs { get; set; }
        public double VehicleBookValue { get; set; }
        public double VehicleSellingPrice { get; set; }

        public Vehicle(VehicleType vehicleType, int vehicleYear, int vehicleMillege, VehicleServiceHistory vehicleServiceHistory, VehicleColour vehicleColour, VehicleSpecs vehicleSpecs, double vehicleBookValue, double vehicleSellingPrice)
        {
            VehicleType = vehicleType;
            VehicleYear = vehicleYear;
            VehicleMillege = vehicleMillege;
            VehicleServiceHistory = vehicleServiceHistory;
            VehicleColour = vehicleColour;
            VehicleSpecs = VehicleSpecs;
            VehicleBookValue = vehicleBookValue;
            VehicleSellingPrice = vehicleSellingPrice;
        }
    }
}
