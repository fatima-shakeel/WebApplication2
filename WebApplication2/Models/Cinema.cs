using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public string Owner { get; set; }
        public string HallNo { get; set; }
    }
}
