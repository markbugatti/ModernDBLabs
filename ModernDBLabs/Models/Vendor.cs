using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BasicRequestLab.Models
{
    [Table("Vendors")]
    public partial class Vendor
    {
        [Key]
        public int Cnum { get; set; }
        
        public string Sname { get; set; }
        public string City { get; set; }
        public decimal? Comm { get; set; }
    }
}
