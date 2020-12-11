using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employment_advertisement_project.Model;

namespace Employment_advertisement_project.Data
{
    public class EAPdatabase : DbContext
    {
        public EAPdatabase (DbContextOptions<EAPdatabase> options)
            : base(options)
        {
        }

        public DbSet<Employment_advertisement_project.Model.Employer_detail> Employer_detail { get; set; }

        public DbSet<Employment_advertisement_project.Model.Candidate_detail> Candidate_detail { get; set; }

        public DbSet<Employment_advertisement_project.Model.Job_detail> Job_detail { get; set; }

        public DbSet<Employment_advertisement_project.Model.Apply_job_detail> Apply_job_detail { get; set; }
    }
}
