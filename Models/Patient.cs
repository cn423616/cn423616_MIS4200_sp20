using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cn423616_MIS4200.Models
{
    public class Patient
    {
        public int patientID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime patientSince { get; set; }

        public ICollection<Visit> Visit { get; set; }

    }
}