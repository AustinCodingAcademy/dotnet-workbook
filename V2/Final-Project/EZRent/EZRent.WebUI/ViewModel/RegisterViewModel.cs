﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EZRent.WebUI.ViewModel
{
    public class RegisterViewModel
    {
        [Required, EmailAddress, MaxLength(256)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password)]
        [Display(Name = "Confirmed Password")]
        [Compare("Password", ErrorMessage = "Password does not match")]
        public string ConfirmedPassword { get; set; }
    }
}
