using desafioDev.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Models
{
    [Table("Equipament")]
    public class Equipament
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }

        [Display(Name = "Descrição")]
        private string description;
        public string Description { get { return description; } set { description = value; } }

  
        /*      
         *      
         *      private int typeEquipamentId;
        public int TypeEquipamentId { get { return typeEquipamentId; } set { typeEquipamentId = value; } }
    private int flooringId;
             public int FlooringId { get { return flooringId; } set { flooringId = value; } }
             private ICollection<Flooring> flooring;
             public ICollection<Flooring> Flooring { get { return flooring; } set { flooring = value; } }
        */

        private ETypeEquipament typeEquipament;
        public ETypeEquipament TypeEquipament { get { return typeEquipament; } set { typeEquipament = value; } }


        private EquipamentStatus status;
        public EquipamentStatus Status { get { return status; } set { status = value; } }

        private DateTime created_at;
        public DateTime Created_at { get { return created_at; } set { created_at = value; } }
        private DateTime updated_at { get; set; }
        public DateTime Updated_at { get { return updated_at; } set { updated_at = value; } }


        public Equipament() { }
       
        public Equipament(int _id, string _description,ETypeEquipament _EtypeEquipament, EquipamentStatus _status)
        {
           // Console.WriteLine("\n\n\n_typeEqupamentID+" + _typeEquipamentId + "\n\n\n");
            description = _description;
            typeEquipament = _EtypeEquipament;
         //   flooring = new List<Flooring>();
            status = _status;
        }

/*
        public void AddSurvey(Flooring obj)
        {
            flooring.Add(obj);
        }

        public void RemoveSurvey(Flooring obj)
        {
            flooring.Remove(obj);
        }
*/

    }
}
