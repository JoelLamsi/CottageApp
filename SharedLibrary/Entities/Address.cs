using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SharedLibrary.Entities
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string StreetAddress { get; set; }
        [Required]
        [StringLength(10)]
        public string ZipCode { get; set; }
        [StringLength(100)]
        public string? Region { get; set; }
        [Required]
        [StringLength(100)]
        public string City { get; set; }
        [Required]
        [StringLength(100)]
        public string Country { get; set; }
    }
}