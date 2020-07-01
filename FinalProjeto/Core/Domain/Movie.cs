using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProjeto.Core.Domain
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Required(ErrorMessage = "O titlos epibaletai"), MaxLength(60), MinLength(2)]
        public string Title { get; set; }
        [Required, Range(0, 10)]
        public double Rating { get; set; }
        public Country Country { get; set; }
        [Required]
        [Display(Name = "Production Year")]
        public DateTime ProductionYear { get; set; }
        [Required, Range(0, 1200)]
        public int Duration { get; set; }  //Minutes
        [Display(Name = "Image")]
        public string PhotoUrl { get; set; }
        [Display(Name = "Trailer")]
        public string TrailerUrl { get; set; }
        public double? Price { get; set; }
        [Display(Name = "I've watched it!")]
        public bool Watched { get; set; }


        //Navigation Properties
        public virtual ICollection<Actor> Actors { get; set; }
        public int DirectorId { get; set; }
        public virtual Director Director { get; set; }

        public int? GenreId { get; set; }
        public virtual Genre Genre { get; set; }

    }

}