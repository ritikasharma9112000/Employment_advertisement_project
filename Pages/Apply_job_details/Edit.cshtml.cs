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

namespace Employment_advertisement_project.Pages.Apply_Job_Details
{
    public class EditModel : PageModel
    {
        private readonly Employment_advertisement_project.Data.Employment_advertisementDatabase _context;

        public EditModel(Employment_advertisement_project.Data.Employment_advertisementDatabase context)
        {
            _context = context;
        }

        [BindProperty]
        public Apply_Job_Detail Apply_Job_Detail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Apply_Job_Detail = await _context.Apply_Job_Detail
                .Include(a => a.Candidate_Detail)
                .Include(a => a.Job_Detail).FirstOrDefaultAsync(m => m.Id == id);

            if (Apply_Job_Detail == null)
            {
                return NotFound();
            }
           ViewData["Candidate_DetailId"] = new SelectList(_context.Candidate_Detail, "Id", "Name_of_candidate");
           ViewData["Job_DetailId"] = new SelectList(_context.Job_Detail, "Id", "Job_role");
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

            _context.Attach(Apply_Job_Detail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Apply_Job_DetailExists(Apply_Job_Detail.Id))
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

        private bool Apply_Job_DetailExists(int id)
        {
            return _context.Apply_Job_Detail.Any(e => e.Id == id);
        }
    }
}
