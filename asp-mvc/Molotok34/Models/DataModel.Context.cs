﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Molotok34.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_a87a62_gsmolotok34Entities : DbContext
    {
        public db_a87a62_gsmolotok34Entities()
            : base("name=db_a87a62_gsmolotok34Entities")
        {
        }

        public static db_a87a62_gsmolotok34Entities context;

        public static db_a87a62_gsmolotok34Entities GetContext()
        {
            if (context == null)
                context = new db_a87a62_gsmolotok34Entities();
            return context;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Categoris> Categoris { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<ClientService> ClientService { get; set; }
        public virtual DbSet<FurnitureOrders> FurnitureOrders { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Services> Services { get; set; }
    }
}
