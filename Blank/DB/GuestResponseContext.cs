using Blank.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Blank.DB
{
    public class GuestResponseContext : DbContext
    {
        public GuestResponseContext() : base("name=GuestResponse")
        {
        }

        public virtual DbSet<GuestResponse> Guests { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
