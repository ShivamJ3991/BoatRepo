using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boat.Model
{
    public class Boat : BaseModel
    {
        public string BoatName { get; set; }
        public string BoatHolderName { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsRentedOut { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime OutTime { get; set; }
        public int RentRate { get; set; }
        public long ImageId { get; set; }

        
    }
}
