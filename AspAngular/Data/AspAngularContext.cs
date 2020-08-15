using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspAngular.Models;

namespace AspAngular.Data
{
    public class AspAngularContext : DbContext
    {
        public AspAngularContext (DbContextOptions<AspAngularContext> options)
            : base(options)
        {
        }

        public DbSet<AspAngular.Models.User> User { get; set; }
    }
}
