﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Employment_advertisement_project.Data;
using Employment_advertisement_project.Model;

namespace Employment_advertisement_project.Pages.Candidate_details
{
    public class DeleteModel : PageModel
    {
        private readonly Employment_advertisement_project.Data.EAPdatabase _context;

        public DeleteModel(Employment_advertisement_project.Data.EAPdatabase context)
        {
            _context = context;
        }

        [BindProperty]
        public Candidate_detail Candidate_detail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Candidate_detail = await _context.Candidate_detail.FirstOrDefaultAsync(m => m.ID == id);

            if (Candidate_detail == null)
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

            Candidate_detail = await _context.Candidate_detail.FindAsync(id);

            if (Candidate_detail != null)
            {
                _context.Candidate_detail.Remove(Candidate_detail);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}