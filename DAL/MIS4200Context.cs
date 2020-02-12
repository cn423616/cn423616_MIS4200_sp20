using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cn423616_MIS4200.Models;
using System.Data.Entity;

namespace cn423616_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {

        }

        public DbSet<Visit> Visits { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<VisitDetail> VisitDetails { get; set; }

    }
}