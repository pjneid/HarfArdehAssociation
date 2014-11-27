using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarfArdehAssociation.Models;

namespace HarfArdehAssociation.DAL
{
    public class AssociationContext : DbContext
    {
        public AssociationContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<People> Peoples { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
