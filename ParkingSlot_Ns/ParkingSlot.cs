using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingManagement.ParkingSlot_Ns
{
    public abstract class ParkingSlot
    {
        public SlotSizeEnum ParkingSlotSize{get;set;}
        public int ParkingSlotNumber{get;set;}
        public bool IsOccupied{get;set;}
        public DateTime StartTime{get;set;}
        public DateTime  EndTime{get;set;}
        
    }
}