using Microsoft.EntityFrameworkCore;
using OpheliaDigitalWare.Api.Client;
using OpheliaDigitalWare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpheliaDigitalWare.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {   
        }

        public DbSet<Provider> Provider { get; set; }
        public DbSet<Client> Client { get; set; }
    }
}
