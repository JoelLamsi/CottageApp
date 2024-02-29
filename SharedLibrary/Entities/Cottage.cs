using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SharedLibrary.Entities
{
    public class Cottage
    {
        public int Id { get; set; }
        [Required, StringLength(100, ErrorMessage = "Title must be between 5 and 100 character", MinimumLength = 5)]
        public string Title { get; set; }
        [StringLength(500)]
        public string? Description { get; set; }
        public string? PictureUrl { get; set; }
        [NotMapped]
        public List<int>? Ratings { get; set; } = [];
        public DateTime? DateAdded { get; set; }
        public int? Rooms { get; set; }
        public bool? IsSauna { get; set; }
        public bool? IsElectricity { get; set; }

        [Required]
        public decimal CostPerDay { get; set; }

        [NotMapped]
        public float? AvgRating 
        {
            get { return AvgRatings(); }
        }

        private float AvgRatings()
        {
            if (Ratings.Count > 0)
            {
                var count = Ratings.Count;
                var sum = 0;
                foreach (var i in Ratings)
                {
                    sum += i;
                }
                return sum / count;
            }
            else return 0;
        }

        [NotMapped]
        public List<Reservation>? Reservations { get; set; }
    }
}
