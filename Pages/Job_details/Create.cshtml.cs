using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Employment_advertisement_project.Data;
using Employment_advertisement_project.Models;

namespace Employment_advertisement_project.Pages.Job_details
{
    public class CreateModel : PageModel
    {
        private readonly Employment_advertisement_project.Data.Employment_advertisementDatabase _context;

        public CreateModel(Employment_advertisement_project.Data.Employment_advertisementDatabase context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Employer_DetailId"] = new SelectList(_context.Employer_Detail, "Id", "Employer_name");
            return Page();
        }

        [BindProperty]
        public Job_Detail Job_Detail { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Job_Detail.Add(Job_Detail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
