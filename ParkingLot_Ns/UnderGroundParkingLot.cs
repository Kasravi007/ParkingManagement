using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ParkingManagement.ParkingLot_Ns
{
    public class UnderGroundParkingLot:ParkingLot
    {
        public UnderGroundParking(ParkingFloor parkingfloor)
        {
            this.ParkingFloors.Add(parkingfloor);

        }
        
    }
}