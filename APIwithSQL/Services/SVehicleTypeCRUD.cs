using APIwithSQL.Interfaces;
using APIwithSQL.Models;
using APIwithSQL.SQLContext;

namespace APIwithSQL.Services
{
    public class SVehicleTypeCRUD : IVehicleType
    {
        private readonly SqlDbContext Db;
        public SVehicleTypeCRUD(SqlDbContext dbContext)
        {
                this.Db = dbContext;
        }

        public async Task<int> Save(VehicleType VT)
        {
           VT.CretaedOn = DateTime.Now;
           await Db.TAT_VehicleType_Mst.AddAsync(VT);
           int result =  Db.SaveChanges();
           return result;
        }
    }
}
