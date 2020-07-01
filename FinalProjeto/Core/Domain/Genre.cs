using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjeto.Core.Domain
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Kind { get; set; }

        //Navigation Properties
        public virtual ICollection<Movie> Movies { get; set; }
    }

}