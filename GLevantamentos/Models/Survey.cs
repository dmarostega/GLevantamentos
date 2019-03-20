using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Models
{
    [Table("Survey")]
    public class Survey
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }

        [Required(ErrorMessage = " {0} é obrigatório")]
        [Display(Name = "Cliente")]
        public int ClientId { get; set; }

       // public int ClientId { get { return clientId; } set { clientId = value; } }

        public Client Client { get; set; }        
       // public Client Client { get { return client; } set { client = value; } }


        private string description;
        [Display(Name = "Descrição")]
        public string Description { get { return description; } set { description = value; } }

        private int userId;
        [Required(ErrorMessage = " {0} é obrigatório")]
        [Display( Name ="Usuário")]
        public int UserId { get { return userId; } set { userId = value; } }
        private User user;
        public User User { get { return user; } set{ user = value; } }

      //  public virtual ICollection<SurveyBlock> Blocks { get; set; } = new List<SurveyBlock>();

        private DateTime created_at;
        public DateTime Created_at { get { return created_at; } set { created_at = value; } }
        private DateTime updated_at { get; set; }
        public DateTime Updated_at { get { return updated_at; } set { updated_at = value; } }


        public Survey() { }

        public Survey(int _id,string _description, Client _client, User _user)
        {
            //id = _id;
            description = _description;
            Client = _client;
            User = _user;
        }
        
    }
}
