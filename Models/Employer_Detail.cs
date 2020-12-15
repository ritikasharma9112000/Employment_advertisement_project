﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employment_advertisement_project.Models

{   //This class display the employer details under which it has employer id, employerdate of establishment, address of employer//
    public class Employer_Detail
   
    {
     
        public int Id { get; set; }
        public string Employer_name { get; set; }
        public DateTime Date_of_establishment { get; set; }
        public string Address_of_employer { get; set; }
    }
}