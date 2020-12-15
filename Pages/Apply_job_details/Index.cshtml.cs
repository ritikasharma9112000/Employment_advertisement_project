using System;
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
    public class IndexModel : PageModel
    {
        private readonly Employment_advertisement_project.Data.Employment_advertisementDatabase _context;

        public IndexModel(Employment_advertisement_project.Data.Employment_advertisementDatabase context)
        {
            _context = context;
        }

        public IList<Apply_Job_Detail> Apply_Job_Detail { get;set; }

        public async Task OnGetAsync()
        {
            Apply_Job_Detail = await _context.Apply_Job_Detail
                .Include(a => a.Candidate_Detail)
                .Include(a => a.Job_Detail).ToListAsync();
        }
    }
}
