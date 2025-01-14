using Microsoft.EntityFrameworkCore;

namespace Portfolio.Data
{
    public class DBcontext : DbContext
    {

        public DBcontext(DbContextOptions<DBcontext> options) : base(options) { 
        }
        public DbSet<Dbdata> Dbdata { get; set; }
    }
    
}