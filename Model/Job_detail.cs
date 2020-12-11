using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employment_advertisement_project.Model
{
    //This class display the job details under which it has job id, job role, job type, job salary, job description, employer id//
    public class Job_detail
    {
        public int ID { get; set; }
        public string Job_role { get; set; }
        public string Job_type { get; set; }
        public decimal Job_salary { get; set; }
        public string Job_description { get; set; }
        public int Employer_id { get; set; }
        public Employer_detail Employer_obj { get; set; }
    }
}
