using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoNetCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IDictionary<int, string> data = new Dictionary<int, string> { { 1, "Chris" }, { 2, "Joe" }, { 3, "Dan" }, { 4, "Wes" }, { 5, "Phil" } };

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(data);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            string value;
            if (data.TryGetValue(id, out value))
                return Ok(value);
            return NotFound();
        }
    }
}
