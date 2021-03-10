using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Backend.Data
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(200)]
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        
        [StringLength(200)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [Required]
        public Address HomeAddress { get; set; }
    }
}