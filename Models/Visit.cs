using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace cn423616_MIS4200.Models
{
    public class Visit
    {
        [Key]
        public int visitID { get; set; }
        public string description { get; set; }
        public DateTime visitDate { get; set; }

        public ICollection<VisitDetail> VisitDetail { get; set; }

        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }

        public int doctorID { get; set; }
        
       
    }
}