using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Models
{

    [Table("Block")]
    public class Block
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }

        [Display(Name = "Descrição")]
        private string description;
        public string Description { get { return description; } set { description = value; } }
/*
        private int surveyBlockId;
        public int SurveyBlockId { get { return surveyBlockId; } set { surveyBlockId = value; } }
  
        private ICollection<SurveyBlock> surveyBlock;
        public virtual ICollection<SurveyBlock> SurveyBlock { get { return surveyBlock; } set { surveyBlock = value; } }

      private ICollection<Flooring> flooarings;
        public ICollection<Flooring> Flooarings { get { return flooarings; } set { flooarings = value; } }
        */
        private DateTime created_at;
        public DateTime Created_at { get { return created_at; } set { created_at = value; } }
        private DateTime updated_at { get; set; }
        public DateTime Updated_at { get { return updated_at; } set { updated_at = value; } }


        public Block() { }

        public Block(int id, string description)
        {
            /*Id = id;*/
            Description = description;
           // SurveyBlock = new List<SurveyBlock>();
        }

        /*public void AddSurvey(SurveyBlock obj)
        {
            SurveyBlock.Add(obj);
        }
        */
      /*  public void RemoveSurvey(SurveyBlock obj)
        {
            SurveyBlock.Remove(obj);
        }
        */

    }
}
