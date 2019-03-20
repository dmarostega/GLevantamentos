using GLevantamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Models.ViewModel
{
    public class EmployeeFormViewModel
    {
        public Employee Employee { get; set; }
        public ICollection<City> Cities { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
