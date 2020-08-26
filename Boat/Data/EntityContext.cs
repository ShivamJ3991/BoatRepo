using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boat.Data
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Boat.Model.Boat> Boat { get; set; }

        public DbSet<Boat.Model.BoatRentDetail> BoatRentDetail { get; set; }

        public DbSet<Boat.Model.ImageFile> ImageFile { get; set; }
    }
}
