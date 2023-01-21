using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCPractice.Models
{
    public class EmpModel
    {
        [Required]
        public int empid { get; set; }
        [Required]
        public string empname { get; set; }
        public string reporting { get; set; }
        public string doj { get; set; }
        public string role { get; set; }
    }
}