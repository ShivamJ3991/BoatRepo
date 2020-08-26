using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boat.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;

namespace Boat
{
    public class EditModel : PageModel
    {
        private readonly IBoatService boatService;

        [BindProperty]
        public Boat.Model.Boat Boat { get; set; }

        [BindProperty]
        public IFormFile FormFile { get; set; }

        public EditModel(IBoatService boatService)
        {
            this.boatService = boatService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Boat.Id > 0)
                Boat = this.boatService.UpdateBoat(Boat);
            else
                Boat = this.boatService.AddBoat(Boat);
            return RedirectToPage("./Detail", new { boatId = Boat.Id });

        }

        public class BoatVM {

            public string BoatName { get; set; }
            public string BoatHolderName { get; set; }

            public int RentRate { get; set; }

            public IFormFile FormFile { get; set; }
        }

    }
}