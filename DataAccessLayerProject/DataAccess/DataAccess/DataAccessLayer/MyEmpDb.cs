using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.Models;

namespace DataAccess.DataAccessLayer
{
    public class MyEmpDb : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("tblEmployee");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> employees { set; get; } 
    }
}