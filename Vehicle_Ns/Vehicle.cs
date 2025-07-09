namespace ParkingManagement.Vehicle_Ns
{
    public abstract class Vehicle
    {
        public string NumberPlate{get;set;}
        public VehicleType Type{get;set;}
        public bool isParked{get;set;}  
    }
}