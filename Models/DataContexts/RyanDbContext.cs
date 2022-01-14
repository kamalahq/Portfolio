using Microsoft.EntityFrameworkCore;
using Ryan.Web.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ryan.Web.UI.Models.DataContexts
{
    public class RyanDbContext : DbContext
    {
        public RyanDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet <ContactMe> Contacts{ get; set; }
        public DbSet<NewClass> News{ get; set; }
        
    }
}
