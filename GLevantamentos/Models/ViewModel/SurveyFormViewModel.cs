using GLevantamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace GLevantamentos.Models.ViewModel
{
    public class SurveyFormViewModel
    {
        public Survey Survey { get; set; }
        public  ICollection<Client> Clients { get; set; }
        public  ICollection<User> Users { get; set; }
        public ICollection<Block> Blocks { get; set; }
        public ICollection<Flooring> Floorings { get; set; }
        public ICollection<Equipament> Equipaments { get; set; }
    }
}
