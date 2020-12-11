using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Employment_advertisement_project.Data;
using Employment_advertisement_project.Model;

namespace Employment_advertisement_project.Pages.Employer_details
{
    public class DetailsModel : PageModel
    {
        private readonly Employment_advertisement_project.Data.EAPdatabase _context;

        public DetailsModel(Employment_advertisement_project.Data.EAPdatabase context)
        {
            _context = context;
        }

        public Employer_detail Employer_detail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employer_detail = await _context.Employer_detail.FirstOrDefaultAsync(m => m.ID == id);

            if (Employer_detail == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
