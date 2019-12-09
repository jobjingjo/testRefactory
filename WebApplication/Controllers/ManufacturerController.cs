using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.DTO;
using WebApplication.Services.Abstract;
using WebApplication.Services.Models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _manufacturerService;
        private readonly IMapper _mapper;

        public ManufacturerController(IManufacturerService manufacturerService,
            IMapper mapper)
        {
            _manufacturerService = manufacturerService ?? throw new ArgumentNullException(nameof(manufacturerService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        //todo: Create a method to get manufacturer name by model

        // GET api/values/5
        [HttpGet("{model}")]
        public ActionResult<string> GetNameByModel(string model)
        {
            //http://localhost:51015/api/manufacturer/xxx
            //return notfound and bad request
            return _manufacturerService.GetManufacturerByModel(model);
        }

        //todo: create a method to return all manufacturers and number of models for these manufacturers
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<ManufacturerDto>> GetAll()
        {
            //https://stackoverflow.com/questions/7741307/automapper-list-to-int-count
            //http://localhost:51015/api/manufacturer/
            //https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio
            //https://code-maze.com/automapper-net-core/
            IList<Manufacturer> founds = _manufacturerService.GetAll();
            var dtos = _mapper.Map<IList<ManufacturerDto>>(founds);
            return dtos.ToList();
        }
    }
}