using Boat.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boat.Implementation
{
    public class BoatService : IBoatService
    {
        public readonly IRepository<Boat.Model.Boat> repositoryBoat;
        public BoatService(IRepository<Boat.Model.Boat> repositoryBoat)
        {
            this.repositoryBoat = repositoryBoat;
        }
        public Model.Boat AddBoat(Model.Boat boat)
        {
            return this.repositoryBoat.Insert(boat);
        }

        public IEnumerable<Model.Boat> GetAllBoat()
        {
            return this.repositoryBoat.GetAll();
        }

        public Model.Boat GetBoatById(long boatId)
        {
            return this.repositoryBoat.Get(boatId);
        }

        public Model.Boat UpdateBoat(Model.Boat boat)
        {
            return this.repositoryBoat.Update(boat);
        }
    }
}
