﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelMvcProject.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbOtelEntities : DbContext
    {
        public DbOtelEntities()
            : base("name=DbOtelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblHakkimda> TblHakkimda { get; set; }
        public virtual DbSet<Tbliletisim> Tbliletisim { get; set; }
        public virtual DbSet<TblMesaj> TblMesaj { get; set; }
        public virtual DbSet<TblYeniKayit> TblYeniKayit { get; set; }
        public virtual DbSet<TblMisafir> TblMisafir { get; set; }
        public virtual DbSet<TblRezervasyon> TblRezervasyon { get; set; }
    }
}
