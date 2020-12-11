﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Employment_advertisement_project.Data;
using Employment_advertisement_project.Model;

namespace Employment_advertisement_project.Pages.Job_details
{
    public class DetailsModel : PageModel
    {
        private readonly Employment_advertisement_project.Data.EAPdatabase _context;

        public DetailsModel(Employment_advertisement_project.Data.EAPdatabase context)
        {
            _context = context;
        }

        public Job_detail Job_detail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Job_detail = await _context.Job_detail.FirstOrDefaultAsync(m => m.ID == id);

            if (Job_detail == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}