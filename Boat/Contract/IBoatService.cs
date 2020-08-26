using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boat.Contract
{
    public interface IBoatService
    {
       public IEnumerable<Boat.Model.Boat> GetAllBoat();

        public Boat.Model.Boat UpdateBoat(Boat.Model.Boat boat);

        public Boat.Model.Boat AddBoat(Boat.Model.Boat boat);

        public Boat.Model.Boat GetBoatById(long boatId);
    }
}
