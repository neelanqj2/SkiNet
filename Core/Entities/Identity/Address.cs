﻿using Core.Entities.Identity;
using System.ComponentModel.DataAnnotations;

namespace Core
{
    public class Address
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        [Required]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}