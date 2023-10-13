using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models;
public class ReservationModel 
    {
        [Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
        [Required, StringLength(200)]
        public string FirstName { get; set; }
        [Required, StringLength(200)]
        public string LastName { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
    }
