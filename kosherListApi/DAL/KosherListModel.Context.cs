﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KosherListEntities : DbContext
    {
        public KosherListEntities()
            : base("name=KosherListEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Store_tbl> Store_tbl { get; set; }
        public virtual DbSet<Updates_tbl> Updates_tbl { get; set; }
        public virtual DbSet<Users_tbl> Users_tbl { get; set; }
        public virtual DbSet<Worker_tbl> Worker_tbl { get; set; }
    }
}