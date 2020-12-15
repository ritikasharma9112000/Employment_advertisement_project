using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employment_advertisement_project.Models;

namespace Employment_advertisement_project.Data
{
    public class Employment_advertisementDatabase : DbContext
    {
        public Employment_advertisementDatabase (DbContextOptions<Employment_advertisementDatabase> options)
            : base(options)
        {
        }

        public DbSet<Employment_advertisement_project.Models.Candidate_Detail> Candidate_Detail { get; set; }

        public DbSet<Employment_advertisement_project.Models.Employer_Detail> Employer_Detail { get; set; }

        public DbSet<Employment_advertisement_project.Models.Job_Detail> Job_Detail { get; set; }

        public DbSet<Employment_advertisement_project.Models.Apply_Job_Detail> Apply_Job_Detail { get; set; }
    }
}
