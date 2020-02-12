using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cn423616_MIS4200.Models
{
    public class VisitDetail
    {
        public int visitDetailID { get; set; }
        public decimal price { get; set; }

        public int visitID { get; set; }
        public virtual Visit Visit { get; set; }

        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }

    }
}