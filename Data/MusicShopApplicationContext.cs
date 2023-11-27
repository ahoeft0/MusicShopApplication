using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicShopApplication.Models;

namespace MusicShopApplication.Data
{
    public class MusicShopApplicationContext : DbContext
    {
        public MusicShopApplicationContext (DbContextOptions<MusicShopApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MusicShopApplication.Models.Music> Music { get; set; } = default!;
    }
}
