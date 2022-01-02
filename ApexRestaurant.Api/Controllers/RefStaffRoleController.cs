using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SRefStaffRole;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("api/refstaffrole")]
    public class RefStaffRoleController : ControllerBase
    {
        private readonly IRefStaffRoleService _refStaffRoleService;

        public RefStaffRoleController(IRefStaffRoleService refStaffRoleService)
        {
            _refStaffRoleService = refStaffRoleService ;
        }

        [HttpGet]
        [Route("{id}")]

        public IActionResult Get([FromRoute] int id)
        {
            var refstaffrole = _refStaffRoleService.GetById(id);

            if(refstaffrole == null)
                return NotFound();

            return Ok(refstaffrole);
        }

        [HttpGet]
        [Route("")]

        public IActionResult GetAll()
        {
            var refstaffrole = _refStaffRoleService.GetAll();
            return Ok();
        }

        [HttpPost]
        [Route("")]

        public IActionResult Post([FromBody] RefStaffRole model )
        {
            _refStaffRoleService.Insert(model);
            return Ok();
        }

        [HttpPut]
        [Route("")]

        public IActionResult Put([FromBody] RefStaffRole model )
        {
             _refStaffRoleService.Update(model);
            return Ok();
        }


        [HttpDelete]
        [Route("")]

        public IActionResult Delete([FromBody] RefStaffRole model )
        {
             _refStaffRoleService.Delete(model);
            return Ok();
        }
    }

}