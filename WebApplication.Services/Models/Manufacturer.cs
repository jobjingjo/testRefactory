﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Services.Models
{
    public class Manufacturer
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string ManufacturerName { get; set; }

        public virtual IList<VehicleModel> Models { get; set; }
    }
}