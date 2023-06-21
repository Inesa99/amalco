using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Amalco.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Amalco.Data.Models.Profile;

namespace Amalco.Data
{
   public class Context:IdentityDbContext<IdentityUser>
    {
        public Context(DbContextOptions<Context> options):base(options)
        { }

        public DbSet<Service> Services { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<VacancyResponse> VacancyResponses { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Service>().HasQueryFilter(s => !s.Deleted);
            modelBuilder.Entity<Review>().HasQueryFilter(r => !r.Deleted);
            modelBuilder.Entity<Vacancy>().HasQueryFilter(v => !v.Deleted);
        }
    }

    public class ProfileContext:DbContext
    {
        public ProfileContext(DbContextOptions<ProfileContext> options) : base(options)
        { }
        public DbSet<Nyanya> Nyanyas { get; set; }
        public DbSet<Domrabotnica> Domrabotnicas { get; set; }
        public DbSet<Povar> Povars { get; set; }
        public DbSet<Sidelka> Sidelkas { get; set; }
        public DbSet<Voditel> Voditels { get; set; }
        public DbSet<Semeynaya_Para> Semeynaya_Para { get; set; }
        public DbSet<ForeignStaff> ForeignStaffs { get; set; }
        public DbSet<Assistant> Assistants { get; set; }
        
         
    }
}
