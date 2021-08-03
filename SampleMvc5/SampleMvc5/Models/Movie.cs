﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMvc5.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int GenreIden { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int NumberInStock { get; set; }
    }
}