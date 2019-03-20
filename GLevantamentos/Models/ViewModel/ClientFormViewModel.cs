using GLevantamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Models.ViewModel
{
    public class ClientFormViewModel
    {
        public Client Client { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
