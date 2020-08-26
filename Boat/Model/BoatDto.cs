using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boat.Model
{
    public class BoatDto : Boat
    {
        public IFormFile FormFile { get; set; }
    }
}
