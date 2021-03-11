using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class Cottage
    {
        public int Id { get; set; }
        [Required, StringLength(100, ErrorMessage = "Title must be between 5 and 100 character", MinimumLength = 5)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        [NotMapped]
        public int[] Ratings { get; set; } = new int[] {0};
        public DateTime DateAdded { get; set; }
        public int Rooms { get; set; }
        public bool IsSauna { get; set; }
        public bool IsElectricity { get; set; }

        public float AvgRating 
        {
            get { return AvgRatings(); }
        }
        [Required]
        public decimal CostPerDay { get; set; }

        private float AvgRatings()
        {
            var count = Ratings.Length;
            var sum = 0;
            foreach (var i in Ratings)
            {
                sum += i;
            }
            return sum / count;
        }
    }
}
