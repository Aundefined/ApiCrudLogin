using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PruebaDbFirst.Models;

namespace PruebaDbFirst.Models
{
    public class PruebaDbFirstContext : IdentityDbContext<ApplicationUser>
    {
        public PruebaDbFirstContext (DbContextOptions<PruebaDbFirstContext> options)
            : base(options)
        {
        }

        public DbSet<PruebaDbFirst.Models.Employees> Employees { get; set; }
        public DbSet<PruebaDbFirst.Models.Clientes> Clientes { get; set; }


    }
}
