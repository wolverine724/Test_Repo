using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationAPI.Model.Domain;

namespace WebApplicationAPI.Data.Data
{
    public class FairyDustContext : DbContext
    {
        public FairyDustContext(DbContextOptions<FairyDustContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
