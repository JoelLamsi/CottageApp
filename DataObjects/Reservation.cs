using System;

namespace Backend.Data
{
    public class Reservation
    {
        public Cottage Cottage { get; set; }
        public decimal TotalPrice { get; set; } = 0.00m;
        public DateTime CheckInDate { get; set; } = new DateTime();
        public DateTime CheckOutDate { get; set; }
    }
}