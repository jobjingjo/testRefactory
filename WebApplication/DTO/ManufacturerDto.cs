using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.DTO
{
    public class ManufacturerDto
    {
        public Guid Id { get; set; }
        public string ManufacturerName { get; set; }
        public int ModelCount { get; set; }
    }
}
