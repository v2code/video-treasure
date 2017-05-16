using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoTreasure.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int? GenreID { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }
    }
}