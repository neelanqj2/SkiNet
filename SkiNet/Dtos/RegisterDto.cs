﻿using System.ComponentModel.DataAnnotations;

namespace SkiNet.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$",ErrorMessage = "You must have a strong password")]
        public string Password { get; set; }
    }
}