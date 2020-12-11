using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Employment_advertisement_project.Data;
using Employment_advertisement_project.Model;

namespace Employment_advertisement_project.Pages.Apply_job_details
{
    public class CreateModel : PageModel
    {
        private readonly Employment_advertisement_project.Data.EAPdatabase _context;

        public CreateModel(Employment_advertisement_project.Data.EAPdatabase context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Apply_job_detail Apply_job_detail { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Apply_job_detail.Add(Apply_job_detail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
