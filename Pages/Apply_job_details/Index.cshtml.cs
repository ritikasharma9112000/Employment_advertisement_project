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
    public class IndexModel : PageModel
    {
        private readonly Employment_advertisement_project.Data.EAPdatabase _context;

        public IndexModel(Employment_advertisement_project.Data.EAPdatabase context)
        {
            _context = context;
        }

        public IList<Apply_job_detail> Apply_job_detail { get;set; }

        public async Task OnGetAsync()
        {
            Apply_job_detail = await _context.Apply_job_detail.ToListAsync();
        }
    }
}
