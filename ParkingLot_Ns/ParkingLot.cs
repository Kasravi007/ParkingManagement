using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkingManagement.ParkingFloor_Ns;

namespace ParkingManagement.ParkingLot_Ns
{
    public abstract class ParkingLot
    {
        public List<ParkingFloor> ParkingFloors{get;set;}
        
    }
}