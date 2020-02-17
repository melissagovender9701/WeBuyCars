using System;
using System.Collections.Generic;
using System.Text;

namespace WeBuyCars.DataAccessLayer
{
    public enum VehicleType
    {
        Car,
        Truck,
        Bus
    }

    public enum SmallVehicleServiceHistory
    {
        FullServiceHistory = 40,
        PartialServiceHistory = 30,
        LowServiceHistory = 0
    }

    public enum BigVehicleServiceHistory
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
        public Make VehicleMake { get; set; }
        public Model VehicleModel { get; set; }
        public DateTime VehicleYear { get; set; }
        public int VehicleMillege { get; set; }
        public SmallVehicleServiceHistory SmallVehicleServiceHistory { get; set; }
        public BigVehicleServiceHistory BigVehicleServiceHistory { get; set; }
        public VehicleColour VehicleColour { get; set; }
        public VehicleSpecs VehicleSpecs { get; set; }
        public double VehicleBookValue { get; set; }
        public double VehicleSellingPrice { get; set; }

        public Vehicle()
        {

        }
        public Vehicle(VehicleType vehicleType, Make vehicleMake, Model vehicleModel, DateTime vehicleYear, int vehicleMillege, SmallVehicleServiceHistory smallVehicleServiceHistory, BigVehicleServiceHistory bigVehicleServiceHistory, VehicleColour vehicleColour, VehicleSpecs vehicleSpecs, double vehicleBookValue, double vehicleSellingPrice)
        {
            VehicleType = vehicleType;
            VehicleMake = vehicleMake;
            VehicleModel = vehicleModel;
            VehicleYear = vehicleYear;
            VehicleMillege = vehicleMillege;
            SmallVehicleServiceHistory = smallVehicleServiceHistory;
            BigVehicleServiceHistory = bigVehicleServiceHistory;
            VehicleColour = vehicleColour;
            VehicleSpecs = VehicleSpecs;
            VehicleBookValue = vehicleBookValue;
            VehicleSellingPrice = vehicleSellingPrice;
        }
    }
}
