﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HiperStar.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FsetMvcEntities : DbContext
    {
        public FsetMvcEntities()
            : base("name=FsetMvcEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AboutUs> AboutUs { get; set; }
        public virtual DbSet<ComponyRule> ComponyRule { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<customerchangepass> customerchangepass { get; set; }
        public virtual DbSet<CustomerProduct> CustomerProduct { get; set; }
        public virtual DbSet<CustomerProjectTicket> CustomerProjectTicket { get; set; }
        public virtual DbSet<discountcode> discountcode { get; set; }
        public virtual DbSet<factor> factor { get; set; }
        public virtual DbSet<Partner_companies> Partner_companies { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<paymentfactor> paymentfactor { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<ProductProperty> ProductProperty { get; set; }
        public virtual DbSet<ProductSuggestion> ProductSuggestion { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<RelativeProduct> RelativeProduct { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sendcost> sendcost { get; set; }
        public virtual DbSet<SlidShow> SlidShow { get; set; }
        public virtual DbSet<StateCustomerProduct> StateCustomerProduct { get; set; }
        public virtual DbSet<Suggestion> Suggestion { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Todo> Todo { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
