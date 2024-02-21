using Product.API.Contracts;
using Product.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Product.API.Controllers
{
    [Route("Product")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IList<Models.Product> GetAll()
        {
            return Storage.GetAll();
        }

        [HttpPost]
        [Authorize(Roles = "Manager, Admin")]
        public IActionResult Create([FromBody]ProductRequest request)
        {
            var model = new Models.Product { Id = request.Id, Name = request.Name };

            if (!Storage.Create(model)) return new BadRequestResult();

            return new OkResult();
        }

        [HttpDelete]
        [Authorize(Policy = "OnlyForOwner")]
        public IActionResult Delete([FromBody]int id) 
        { 
            if (!Storage.Delete(id)) return new BadRequestResult();

            return new OkResult();
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public IActionResult Update([FromBody]ProductRequest request) 
        {
            var model = new Models.Product { Id = request.Id,  Name = request.Name };

            if (!Storage.Update(model)) return new BadRequestResult();
            
            return new OkResult();  
        }
    }   
}
