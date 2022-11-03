

using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {

        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options)
        { 
        
        }

        public DbSet<Region> Regions { get; set; } // We are tell EF to create a Region Table for us if it does not exist
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

    }
}
