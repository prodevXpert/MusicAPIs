using Microsoft.EntityFrameworkCore;
using MusicAPIs.Models;

namespace MusicAPIs.Data
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext>options):base(options)
        {
            
        }
        public DbSet<Song> Songs{ get; set; }
    }
}
