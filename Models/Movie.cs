using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC_ASPCORE.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime releasedate { get; set; }
        public string genric { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal price { get; set; }
    }
}
