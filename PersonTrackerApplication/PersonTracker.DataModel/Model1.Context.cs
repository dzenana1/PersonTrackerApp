﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonTracker.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PersonTrackerDBEntities : DbContext
    {
        public PersonTrackerDBEntities()
            : base("name=PersonTrackerDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brada> Brada { get; set; }
        public virtual DbSet<Celjust> Celjust { get; set; }
        public virtual DbSet<Glava> Glava { get; set; }
        public virtual DbSet<Komentar> Komentar { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Kosa> Kosa { get; set; }
        public virtual DbSet<Nestali> Nestali { get; set; }
        public virtual DbSet<Nos> Nos { get; set; }
        public virtual DbSet<Obrve> Obrve { get; set; }
        public virtual DbSet<Oci> Oci { get; set; }
        public virtual DbSet<Prestupnik> Prestupnik { get; set; }
        public virtual DbSet<Skica> Skica { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usne> Usne { get; set; }
    }
}
