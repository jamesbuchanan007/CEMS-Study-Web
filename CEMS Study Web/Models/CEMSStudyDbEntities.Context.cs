﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CEMS_Study_Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CEMSStudyWebDbEntities1 : DbContext
    {
        public CEMSStudyWebDbEntities1()
            : base("name=CEMSStudyWebDbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ECMPS_GHG> ECMPS_GHG { get; set; }
        public virtual DbSet<ECMPS_PGV> ECMPS_PGV { get; set; }
        public virtual DbSet<ECMPS_QA> ECMPS_QA { get; set; }
        public virtual DbSet<ECMPSEmission> ECMPSEmissions { get; set; }
        public virtual DbSet<ECMPSMonitoringPlan> ECMPSMonitoringPlans { get; set; }
        public virtual DbSet<MATSGuidance> MATSGuidances { get; set; }
        public virtual DbSet<MATSTransition> MATSTransitions { get; set; }
        public virtual DbSet<Part60AppB> Part60AppB { get; set; }
        public virtual DbSet<Part60AppF> Part60AppF { get; set; }
        public virtual DbSet<Part63SubUUUUU> Part63SubUUUUU { get; set; }
        public virtual DbSet<Part75AppD> Part75AppD { get; set; }
        public virtual DbSet<Part75EMP> Part75EMP { get; set; }
        public virtual DbSet<Part75FAM> Part75FAM { get; set; }
        public virtual DbSet<Part75PE> Part75PE { get; set; }
        public virtual DbSet<Part75> Part75 { get; set; }
    }
}
