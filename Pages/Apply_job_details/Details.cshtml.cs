﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Employment_advertisement_project.Data;
using Employment_advertisement_project.Models;

namespace Employment_advertisement_project.Pages.Apply_Job_Details
{
    public class DetailsModel : PageModel
    {
        private readonly Employment_advertisement_project.Data.Employment_advertisementDatabase _context;

        public DetailsModel(Employment_advertisement_project.Data.Employment_advertisementDatabase context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
