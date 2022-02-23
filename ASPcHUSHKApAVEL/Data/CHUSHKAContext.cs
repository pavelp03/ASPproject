using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPcHUSHKApAVEL.Data
{
    public class CHUSHKAContext: DbContext
    {
        public CHUSHKAContext()
        { 

        }
       public CHUSHKAContext(DbContextOptions<CHUSHKAContext>options):
            base(options)
        {

        }
        //Tables
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
