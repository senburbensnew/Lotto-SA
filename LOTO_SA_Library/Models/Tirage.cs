using LOTO_SA_Library.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO_SA_Library.Models
{
    public class Tirage
    {
        public int Id { get; set; }
        public float coefficientPremierNumeroGagnant { get; set; }
        public float coefficientSecondNumeroGagnant { get; set; }
        public float coefficientTroisiemeNumeroGagnant { get; set; }
        public string PremierNumeroGagnant { get; set; }
        public string SecondNumeroGagnant { get; set; }
        public string TroisiemeNumeroGagnant { get; set; }
        public DateTime DateCreation { get; set; }
        public StatutTirage StatutTirage { get; set; }
        public ICollection<MiseJoueur> MiseJoueurs { get; set; }
    }
}
