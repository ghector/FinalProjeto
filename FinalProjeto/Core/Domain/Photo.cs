using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProjeto.Core.Domain
{
    public class Photo
    {
        public int PhotoId { get; set; }
        [Display(Name = "Photo URL")]
        public string Url { get; set; }

        //Navigation Properties
        public virtual Actor Actor { get; set; }
    }

}