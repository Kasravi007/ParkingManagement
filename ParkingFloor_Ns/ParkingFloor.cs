using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkingManagement.ParkingSlot_Ns;

namespace ParkingManagement.ParkingFloor_Ns
{
    public abstract class ParkingFloor
    {
        public List<ParkingSlot> ParkingSlots{get;set;}
        public int FloorNumber{get;set;}
        public int AvailableSlots{get;set;}
        public int OccupiedSlots{get;set;}

    }
    
}