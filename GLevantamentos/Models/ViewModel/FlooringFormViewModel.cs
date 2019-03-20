using GLevantamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Models.ViewModel
{
    public class FlooringFormViewModel
    {
        public Flooring Flooring { get; set; }
        public ICollection<Equipament> Equipaments { get; set; }
    }
}
