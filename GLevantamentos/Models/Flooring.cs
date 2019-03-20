using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Models
{
   [Table("Flooring")]
    public class Flooring
    {   
        public Flooring() { }
        public Flooring(int _id, string _description/*,List<Equipament> _equipaments, Block _block*/)
        {
            description = _description;
           // equipaments = _equipaments;
           // block = new List<Block>();
        }

        private int id;
        public int Id { get { return id; } set { id = value; } }

        [Display(Name = "Descrição")]
        private string description;
        public string Description { get { return description; } set { description = value; } }

        /*    private ICollection<Equipament> equipaments;
        public ICollection<Equipament> Equipaments { get;  set; } = new List<Equipament>();

        private int equipamentId;
            public int EquipamentId { get { return equipamentId; } set{ equipamentId = value; } }
    */
        /*   private int blockId;
           public int BlockId { get { return blockId; } set { blockId = value; } }

           private ICollection<Block> block;
           public ICollection<Block> Block { get { return block; } set { block = value; } }

       */

        private DateTime created_at;
        public DateTime Created_at { get { return created_at; } set { created_at = value; } }
        private DateTime updated_at { get; set; }
        public DateTime Updated_at { get { return updated_at; } set { updated_at = value; } }



    }
}
