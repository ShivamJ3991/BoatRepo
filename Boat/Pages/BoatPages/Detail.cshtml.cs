using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boat.Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Boat
{
    public class DetailModel : PageModel
    {
        private readonly IBoatService boatService;
        public Boat.Model.Boat Boat { get; set; }
        public DetailModel(IBoatService boatService)
        {
            this.boatService = boatService;
        }
        public IActionResult OnGet(long boatId)
        {
            Boat = this.boatService.GetBoatById(boatId);
            if (Boat == null)
                return RedirectToPage("./NotFound");
            return Page();
        }
    }
}