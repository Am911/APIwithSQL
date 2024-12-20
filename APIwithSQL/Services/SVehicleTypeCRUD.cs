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

        public List<VehicleType> GetAll()
        {
            List<VehicleType> vehicleType = Db.TAT_VehicleType_Mst.ToList();
            return vehicleType;
        }

        public bool updateRecord(dynamic id, VehicleType VT)
        {
            var data = Db.TAT_VehicleType_Mst.Find(id);

            if (data != null)
            {
                data.VehicleTypeName = VT.VehicleTypeName;
                data.VehicleEnabled = VT.VehicleEnabled;
                data.Remark = VT.Remark;
                if(Db.SaveChanges() > 0) 
                {
                    return true;

                }
                else {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public bool removeById(dynamic id)
        {
            var data = Db.TAT_VehicleType_Mst.Find(id);
            if (data != null)
            {
                Db.TAT_VehicleType_Mst.Remove(data);
                if(Db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else{
            return false;
            }
        }
    }
}
