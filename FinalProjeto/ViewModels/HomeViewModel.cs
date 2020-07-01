using FinalProjeto.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjeto.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }

    }
}