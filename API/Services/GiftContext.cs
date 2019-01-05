using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class GiftContext : DbContext
    {
        public DbSet<GiftEntity> Gifts { get; set; }

        public GiftContext(DbContextOptions<GiftContext> options) : base(options)
        {
            Database.Migrate();
        }
    }
}
