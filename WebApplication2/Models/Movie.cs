using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string Actor { get; set; }
        public string Actress { get; set; }
        public string Writer { get; set; }
    }
}
