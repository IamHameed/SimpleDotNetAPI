using Microsoft.AspNetCore.Mvc;

namespace SimpleDotNetAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "Apple", "Banana", "Orange" });
        }

        [HttpPost]
        public IActionResult Post(string item)
        {
            return Ok($"Item {item} added successfully");
        }
    }
}
