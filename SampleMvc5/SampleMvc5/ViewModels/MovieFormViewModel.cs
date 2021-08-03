using SampleMvc5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMvc5.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genre { get; set; }
    }
}