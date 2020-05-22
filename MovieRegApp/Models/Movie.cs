using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieRegApp.Models
{
    public class Movie
    {
        [Required (ErrorMessage = "Please enter an ID number")]
        public int ID { get; set; }

        [Required (ErrorMessage = "Please enter a Title")]
        [MaxLength(50, ErrorMessage = "Title must be 50 characters or less") ]
        public string Title { get; set; }
        public string Genre { get; set; }

        //[Range(typeof(DateTime), "1880-01-01", DateTime.Now.ToString(), ErrorMessage = "Date must be between 1880 and now")]
        public DateTime ReleaseDate { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
    }
}
