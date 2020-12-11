using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Employment_advertisement_project.Data;
using Employment_advertisement_project.Model;

namespace Employment_advertisement_project.Pages.Apply_job_details
{
    public class DeleteModel : PageModel
    {
        private readonly Employment_advertisement_project.Data.EAPdatabase _context;

        public DeleteModel(Employment_advertisement_project.Data.EAPdatabase context)
        {
            _context = context;
        }

        [BindProperty]
        public Apply_job_detail Apply_job_detail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Apply_job_detail = await _context.Apply_job_detail.FirstOrDefaultAsync(m => m.ID == id);

            if (Apply_job_detail == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Apply_job_detail = await _context.Apply_job_detail.FindAsync(id);

            if (Apply_job_detail != null)
            {
                _context.Apply_job_detail.Remove(Apply_job_detail);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
