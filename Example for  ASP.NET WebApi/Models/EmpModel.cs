using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SampleWebAPI.Models
{
    public class EmpModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public Nullable<System.DateTime> Date_of_Birth { get; set; }
        public string Location { get; set; }
        public string Degree { get; set; }
        public string Stream { get; set; }


        public int EmpModelId
        {
            get;
            set;
        }
        public string EmpModelName
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string Department
        {
            get;
            set;
        }

        [RegularExpression (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email
        {
            get;
            set;
        }
        public int Phone
        {
            get;
            set;
        }
    }
}