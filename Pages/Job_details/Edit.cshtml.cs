using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Employment_advertisement_project.Data;
using Employment_advertisement_project.Models;

namespace Employment_advertisement_project.Pages.Job_details
{
    public class EditModel : PageModel
    {
        private readonly Employment_advertisement_project.Data.Employment_advertisementDatabase _context;

        public EditModel(Employment_advertisement_project.Data.Employment_advertisementDatabase context)
        {
            _context = context;
        }

        [BindProperty]
        public Job_Detail Job_Detail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Job_Detail = await _context.Job_Detail
                .Include(j => j.Employer_Detail).FirstOrDefaultAsync(m => m.Id == id);

            if (Job_Detail == null)
            {
                return NotFound();
            }
           ViewData["Employer_DetailId"] = new SelectList(_context.Employer_Detail, "Id", "Employer_name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Job_Detail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Job_DetailExists(Job_Detail.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Job_DetailExists(int id)
        {
            return _context.Job_Detail.Any(e => e.Id == id);
        }
    }
}
