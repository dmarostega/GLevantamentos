using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Models
{
    [Table("City")]
    public class City
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }

        private string name;
        [Required(ErrorMessage = " {0} é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = " {0} deve conter de {2} a {1} caracteres.")]
        [Display(Name = " Nome")]
        public string Name { get { return name; } set { name = value; } }

        private int stateId;
        [Display(Name = "Estado")]
        public int StateId { get { return stateId; } set { stateId = value; } }

        private State state;
        public State State { get { return state; } set { state = value; } }

        private DateTime created_at;
        public DateTime Created_at { get { return created_at; } set { created_at = value; } }
        private DateTime updated_at { get; set; }
        public DateTime Updated_at { get { return updated_at; } set { updated_at = value; } }

        public City() { }
        public City(int _id, string _name,State _state)
        {
            name = _name;
            state = _state;
        }
    }
}
