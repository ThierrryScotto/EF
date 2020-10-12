using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EF.Data;
using EF.Models;

namespace EF.Controllers
{
    [ApiController]
    [Route("v1/categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Get([FromServices] DataContext context)
        {
            var categories = await context.Category.ToListAsync();
            return categories;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Category>> Post ([FromServices] DataContext context, [FromBody]Category body)
        {
            if (ModelState.IsValid) 
            {
                context.Category.Add(body);
                await context.SaveChangesAsync();
                return body;
            } 
            else 
            {
                return BadRequest(ModelState);
            }
        }
    }
}