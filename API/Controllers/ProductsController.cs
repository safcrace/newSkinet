using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _dbContext;
        public ProductsController(StoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async ValueTask<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var porducts = await _dbContext.Products.ToListAsync();
            return Ok(porducts);
        }

        [HttpGet("{id}")]
        public async ValueTask<ActionResult<Product>> GetProduct(int id)
        {
            return await _dbContext.Products.FindAsync(id);
        }
    }
}