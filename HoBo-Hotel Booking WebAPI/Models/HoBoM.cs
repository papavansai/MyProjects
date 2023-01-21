using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoBoWebApi.Models
{
    public class HoBoM
    {
        public int S_No { get; set; }
        public string Hotel { get; set; }
        public System.DateTime Arrival { get; set; }
        public System.DateTime Departure { get; set; }
        public string Type { get; set; }
        public int Guests { get; set; }
        public decimal Price { get; set; }
    }
}