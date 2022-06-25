﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Username obbligatorio")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password obbligatoria")]
        public string Password { get; set; }
    }
}
