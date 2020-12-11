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
    public class IndexModel : PageModel
    {
        private readonly Employment_advertisement_project.Data.EAPdatabase _context;

        public IndexModel(Employment_advertisement_project.Data.EAPdatabase context)
        {
            _context = context;
        }

        public IList<Candidate_detail> Candidate_detail { get;set; }

        public async Task OnGetAsync()
        {
            Candidate_detail = await _context.Candidate_detail.ToListAsync();
        }
    }
}