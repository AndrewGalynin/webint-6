using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace web_lab6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static readonly List<string> _values = new List<string>
        {
            "Value1",
            "Value2",
            "Value3"
        };

        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return _values;
        }

        // GET: api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id >= 0 && id < _values.Count)
            {
                return _values[id];
            }

            return NotFound();
        }
    }
}
