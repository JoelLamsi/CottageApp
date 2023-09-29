using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Data
{
    public class Reservation
    {
        public Cottage Cottage { get; set; }
        public decimal TotalPrice { get; set; } = 0.00m;
        [Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
    }
}