﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Employment_advertisement_project.Data;
using Employment_advertisement_project.Model;

namespace Employment_advertisement_project.Pages.Apply_job_details
{
    public class EditModel : PageModel
    {
        private readonly Employment_advertisement_project.Data.EAPdatabase _context;

        public EditModel(Employment_advertisement_project.Data.EAPdatabase context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Apply_job_detail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Apply_job_detailExists(Apply_job_detail.ID))
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

        private bool Apply_job_detailExists(int id)
        {
            return _context.Apply_job_detail.Any(e => e.ID == id);
        }
    }
}