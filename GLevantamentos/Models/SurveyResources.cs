using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Models
{
    public class SurveyResources
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public Survey Surveys { get; set; }
        public int BlockId { get; set; }
        public Block Blocks{get;set;}
        public int FlooringId { get; set; }
        public Flooring Floorings { get; set; }
        public int EquipamentId { get; set; }
        public Equipament Equipaments { get; set; }

        public SurveyResources() { }
        public SurveyResources(int id,Survey survey,Block block, Flooring flooring, Equipament equipament)
        {
            Surveys = survey;
            Blocks = block;
            Floorings = flooring;
            Equipaments = equipament;

        }
    }
}
