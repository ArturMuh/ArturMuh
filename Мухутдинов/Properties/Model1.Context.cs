﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Мухутдинов.NewFolder1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class БД_МухутдиновEntities : DbContext
    {
        public БД_МухутдиновEntities()
            : base("name=БД_МухутдиновEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Abiturenti> Abiturenti { get; set; }
        public virtual DbSet<Lgotnie_documenti> Lgotnie_documenti { get; set; }
        public virtual DbSet<Obrazovanie> Obrazovanie { get; set; }
        public virtual DbSet<Pasportnie_dannie> Pasportnie_dannie { get; set; }
        public virtual DbSet<Sotrudniki> Sotrudniki { get; set; }
        public virtual DbSet<Specilization> Specilization { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Zaconiepredstaviteli> Zaconie_predstaviteli { get; set; }
        public virtual DbSet<Zaivlenie> Zaivlenie { get; set; }
    }
}
