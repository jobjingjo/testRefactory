using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebApplication.DTO;
using WebApplication.Services.Models;

namespace WebApplication
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Manufacturer, ManufacturerDto>()
                .ForMember(x => x.ModelCount, o => o.MapFrom(x => x.Models.Count()));
        }

    }
}
