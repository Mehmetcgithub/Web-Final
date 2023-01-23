using BlazorApp2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HaberApiController : ControllerBase
    {
        private IHaberRepository context;

        public HaberApiController(IHaberRepository ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IEnumerable<Haber> GetProducts()
        {
            return  context.Habers;
        }
       
        [HttpGet("{id}")]
        public  IActionResult GetProduct(int id)
        {
            Haber p = context.Habers.FirstOrDefault(i=>i.HaberId==id);
            if (p == null)
            {
                return NotFound();
            }
            return Ok(p);
        }
    }
}
