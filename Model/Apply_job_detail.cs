using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employment_advertisement_project.Model
{ //This class display the apply job details under which it has apply job id, candidate id, job id, candidate availabilities, candidate notice period//
    public class Apply_job_detail
    {
        
        public int ID { get; set; }
        public int Candidate_id { get; set; }
        public Candidate_detail Candidate_obj { get; set; }
        public int Job_id { get; set; }
        public Job_detail Job_obj { get; set; }
        [Required]
        public string Candidate_availabilities { get; set; }
        public DateTime Candidate_notice_period { get; set; }
    }
}
