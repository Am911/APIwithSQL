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
        [Route("Insert")]
        public async void createVehicleType([FromBody]VehicleType VT)
        {
            int result = await crud.Save(VT);
        }

        [HttpGet]
        [Route("GetAllList")]
        public IActionResult All()
        {
            List<VehicleType> ls = crud.GetAll();
            return Ok(ls);
        }

        [HttpPut]
        [Route("UpdatebyId")]
        public IActionResult updateRecord(int id, [FromBody] VehicleType VT)
        {
            bool result = crud.updateRecord(id, VT);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("DeletebyId")]
        public IActionResult deletebyId(int id)
        {
            bool result = crud.removeById(id);
            if(result)
            {
                return Ok(1);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
