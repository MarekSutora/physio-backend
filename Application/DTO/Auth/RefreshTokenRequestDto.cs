﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Auth
{
    public class RefreshTokenRequestDto
    {
        [Required]
        [StringLength(500)]
        public string RefreshToken { get; set; }
    }
}