using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoMVC_ASPCORE.Models
{
    public class MoviegenreViewModel
    {

        public List<Movie> Movies { get; set; }
        public SelectList genric { get; set; }
        public string Moviegenric { get; set; }
        public string searchstring { get; set; }
    }
}
