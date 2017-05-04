using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoTreasure.Models
{
    public class Genre
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string GenreName { get; set; }
    }
}