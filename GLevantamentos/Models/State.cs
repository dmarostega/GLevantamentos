using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Models
{
    public class State
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }

        [Required(ErrorMessage = " {0} é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = " {0} deve conter de {2} a {1} caracteres.")]
        [Display(Name = " Nome")]
        private string name;
        public string Name { get { return name; } set { name = value; } }

        [Required(ErrorMessage = " {0} é obrigatório")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = " {0} deve conter de {2} caracteres.")]
        [Display(Name = " Nome")]
        private string uf;
        public string UF { get { return uf; } set { uf = value; } }

        private DateTime created_at;
        public DateTime Created_at { get { return created_at; } set { created_at = value; } }
        private DateTime updated_at { get; set; }
        public DateTime Updated_at { get { return updated_at; } set { updated_at = value; } }


        public State() { }
        public State(int _id, string _name, string _uf)
        {
            name = _name;
            uf = _uf;
        }

    }
}
