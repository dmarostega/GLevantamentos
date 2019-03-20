using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Models
{
    [Table("Employee")]
    public class Employee
    {
        public Employee() { }
        public Employee(int _id, string _name, string _email, string _address, User _user, City _city)
        {
            name = _name;
            email = _email;
            address = _address;

            User = _user;
            City = _city;
        }


        private int id;
        public int Id { get { return id; } set { id = value; } }


        private string name;
        [Required(ErrorMessage = " {0} é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = " {0} deve conter de {2} a {1} caracteres.")]
        [Display(Name = "Nome")]
        public string Name { get { return name; } set { name = value; } }

  
        private string email;
     //   [Required(ErrorMessage = " {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "{0} formato inválido.")]
        [Display(Name = "Email")]
        public string Email { get { return email; } set { email = value; } }


        private string address;
        [Display(Name = "Endereço")]
        public string Address { get { return address; } set { address = value; } }
/*

        private string phone;
     //   [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Telefone")]
    //    [RegularExpression("^(d{1,2}[ - ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = " Campo obrigatório.")]
        public string Phone { get { return phone; } set { phone = value; } }
*/

     /*   private DateTime birthDate;
        [Required(ErrorMessage = "{0} é obrigatório!@)")]
        [Display(Name = "Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }
*/
/*
        private double baseSalary;
        //[Required(ErrorMessage = "Campo Obrigatório.")]
     //   [Range(100.0, 70000.0, ErrorMessage = " Valor Inválido! Min. {1} Máx {2} ")]
        [Display(Name = "Remuneração")]
      //  [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get { return baseSalary; } set { baseSalary = value; } }

    */
        private int userId;
        /// [Required(ErrorMessage = "Campo Obrigatório.")]
        [Required(ErrorMessage =" {0} campo obrigatório..")]
        [Display(Name = "Usuário")]
        public int UserId { get { return userId; } set { userId = value; } }
        private User user;
        public User User { get { return user; } set { user = value; } }


        private int cityId;
        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Display(Name = "Cidade")]
        public int CityId { get { return cityId; } set { cityId = value; } }
        private City city;
        public City City { get { return city; } set { city = value; } }

        private DateTime created_at;
        public DateTime Created_at { get { return created_at; } set { created_at = value; } }
        private DateTime updated_at { get; set; }
        public DateTime Updated_at { get { return updated_at; } set { updated_at = value; } }


    }
}
