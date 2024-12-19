using APIwithSQL.Models;
using Microsoft.EntityFrameworkCore;
namespace APIwithSQL.SQLContext
{
    public class SqlDbContext : DbContext 
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> con) : base(con)
        {
                
        }

        public DbSet<VehicleType> TAT_VehicleType_Mst {  get; set; }
    }
}
