using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMenuItem;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("api/menuitem")]
    public class MenuItemController : ControllerBase
    {
        private readonly IMenuItemService _menuItemService;

        public MenuItemController(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService ;
        }

        [HttpGet]
        [Route("{id}")]

        public IActionResult Get([FromRoute] int id)
        {
            var menu = _menuItemService.GetById(id);

            if(menu == null)
                return NotFound();

            return Ok(menu);
        }

        [HttpGet]
        [Route("")]

        public IActionResult GetAll()
        {
            var menus = _menuItemService.GetAll();
            return Ok();
        }

        [HttpPost]
        [Route("")]

        public IActionResult Post([FromBody] MenuItem model )
        {
            _menuItemService.Insert(model);
            return Ok();
        }

        [HttpPut]
        [Route("")]

        public IActionResult Put([FromBody] MenuItem model )
        {
             _menuItemService.Update(model);
            return Ok();
        }


        [HttpDelete]
        [Route("")]

        public IActionResult Delete([FromBody] MenuItem model )
        {
             _menuItemService.Delete(model);
            return Ok();
        }
    }

}