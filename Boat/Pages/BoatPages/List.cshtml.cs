using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boat.Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boat
{
    public class ListModel : PageModel
    {
        private readonly IBoatService boatService; 
        public IEnumerable<Boat.Model.Boat> Boats;

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public ListModel(IBoatService boatService)
        {
            this.boatService = boatService;
        }

        public void OnGet()
        {
            Boats = this.boatService.GetAllBoat();
        }
    }
}