using Microsoft.EntityFrameworkCore;
using bookshop.Models;

namespace bookshop.DataBase
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) //configure dbContext option 
        {
        }
        public DbSet<Register> Register { get; set; }
    }
}
