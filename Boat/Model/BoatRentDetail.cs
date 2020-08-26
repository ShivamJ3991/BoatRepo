using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boat.Model
{
    public class BoatRentDetail : BaseModel
    {
        public long BoatId { get; set; }
        public string HirePersonName { get; set; }
        public DateTime RentedPickUpTime { get; set; }
        public DateTime RentedDeliveryTime { get; set; }
    }
}
