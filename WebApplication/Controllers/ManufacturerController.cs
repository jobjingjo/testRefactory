using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        public ManufacturerController()
        {

        }

        //todo: Create a method to get manufacturer name by model

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> GetNameByModel(string model)
        {
            return "value";
        }

        //todo: create a method to return all manufacturers and number of models for these manufacturers
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}