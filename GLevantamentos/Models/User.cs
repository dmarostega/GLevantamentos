using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Models
{
    public class User
    {
        public User() { }
        public User(int id, string name, String email, string username, string password)
        {
            Name = name;
            Email = email;
            Username = username;
            Password = password;
        }
        private int id;
        public int Id { get { return id; } set { id = value; } }

        [Required(ErrorMessage =" {0} é Obrigatório")]
        [StringLength(50, MinimumLength =3,ErrorMessage = " {0} deve conter de {2} a {1} caracteres.")]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        // public string Name { get { return name; } set { name = value; } }
        [Required(ErrorMessage = " {0} é Obrigatório")]
        [EmailAddress(ErrorMessage ="{0} possui formato inválido")]
        public string Email { get; set; }
        //  public string Email{ get{ return email; } set { email = value; } }
        [Required(ErrorMessage = " {0} é Obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} deve conter de {2} a {1} caracteres. ")]
        [Display(Name = "Usuário")]
        public string Username { get; set; }
        //  public string Username { get { return username; } set { username = value; } }
        [Required(ErrorMessage = " {0} é Obrigatório")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "{0} deve conter de {2} a {1} caracteres. ")]
        [Display(Name = "Senha")]
        public string Password { get; set; }
        //   public string Password { get { return password; } set { password = value; } }


        private DateTime created_at;
        public DateTime Created_at { get{ return created_at; } set { created_at = value; } }
        private DateTime updated_at { get; set; }
        public DateTime Updated_at { get { return updated_at; } set { updated_at = value; } }

    }
}
