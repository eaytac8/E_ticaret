﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ayakkabi_Projesi.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ayakkabiEntities : DbContext
    {
        public ayakkabiEntities()
            : base("name=ayakkabiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AltKategori> AltKategoris { get; set; }
        public virtual DbSet<Ayakkabi> Ayakkabis { get; set; }
        public virtual DbSet<AyakkabiNumara> AyakkabiNumaras { get; set; }
        public virtual DbSet<Iletisim> Iletisims { get; set; }
        public virtual DbSet<Indirim> Indirims { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<Numara> Numaras { get; set; }
        public virtual DbSet<Onerilenler> Onerilenlers { get; set; }
        public virtual DbSet<Sipari> Siparis { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
    }
}
