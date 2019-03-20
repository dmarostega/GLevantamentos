using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Models
{
    [Table("Client")]
    public class Client
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }

        [Required(ErrorMessage = " {0} é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = " {0} deve conter de {2} a {1} caracteres.")]
        [Display(Name = " Nome")]
        private string name;
        public string Name { get { return name; } set { name = value; } }

        [Required(ErrorMessage = " {0} é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = " {0} deve conter de {2} a {1} caracteres.")]
        [Display(Name = "Nome Responsável ")]
        private string nameResponsible;
        public string NameResponsible { get { return nameResponsible; } set { nameResponsible = value; } }

        [Required(ErrorMessage = " {0} é Obrigatório")]
        [EmailAddress(ErrorMessage = "{0} possui formato inválido")]
        [Display(Name = "Email")]
        private string email;
        public string Email { get { return email; } set { email = value; } }

        [Display(Name = "Endereço")]
        private string address;
        public string Address { get { return address; } set { address = value; } }

        [Required(ErrorMessage = " {0} é obrigatório")]
        [Display(Name = "Telefone")]
        private string phone;
        public string Phone { get { return phone; } set { phone = value; } }


        private int cityId;
        public int CityId { get { return cityId; } set { cityId = value; } }
        private City city;
        public City City { get { return city; } set { city = value; } }


        private DateTime created_at;
        public DateTime Created_at { get { return created_at; } set { created_at = value; } }
        private DateTime updated_at { get; set; }
        public DateTime Updated_at { get { return updated_at; } set { updated_at = value; } }


        public Client() { }

        public Client(int _id, string _name, string _email, string _adress, string _phone, string _nameResponsible, City _city)
        {
            name = _name;
            email = _email;
            address = _adress;
            phone = _phone;
            city = _city;
            nameResponsible = _nameResponsible;
        }


    }
}
