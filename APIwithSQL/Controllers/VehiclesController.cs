using APIwithSQL.Interfaces;
using APIwithSQL.Models;
using APIwithSQL.Services;
using APIwithSQL.SQLContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIwithSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleType crud;
        private readonly SqlDbContext context;
        public VehiclesController(SqlDbContext context)
        {
            this.context = context;
            this.crud =new  SVehicleTypeCRUD(context);
        }

        [HttpPost]
        
        public async void createVehicleType([FromBody]VehicleType VT)
        {
            int result = await crud.Save(VT);
        }
    }
}
