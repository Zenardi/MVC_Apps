using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blockbuster.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Name { get; set; }

        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        public byte NumberInStock { get; set; }
    }
}