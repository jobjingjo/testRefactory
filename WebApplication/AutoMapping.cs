using AutoMapper;
using System.Linq;
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
