using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public Cottage Cottage { get; set; }
        public int CottageId { get; set; }
        public decimal TotalPrice { get; set; } = 0.00m;
        [Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
    }
}