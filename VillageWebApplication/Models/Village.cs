using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VillageWebApplication.Models
{
    public partial class Village : DbContext
    {
        public Village()
            : base("name=Village")
        {
        }

      public virtual  DbSet<Resident> Residents { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

       
    }
}
