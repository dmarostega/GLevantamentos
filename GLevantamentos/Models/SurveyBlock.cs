using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Models
{
    public class SurveyBlock
    {
        public int SurveyId { get; set; }
        public virtual Survey Survey { get; set; }

        public int BlockId { get; set; }
        public virtual Block Block { get; set; }
    }
}
