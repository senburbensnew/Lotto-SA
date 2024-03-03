using LOTO_SA_Library.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO_SA_Library.Models
{
    public class MiseJoueur
    {
        public int Id { get; set; }
        public string MisePremierNumeroGagnant { get; set; }
        public string MiseSecondNumeroGagnant { get; set; }
        public string MiseTroisiemeNumeroGagnant { get; set; }
        public string MontantGagne { get; set; }
        public string PremierNumeroGagnant { get; set; }
        public string SecondNumeroGagnant { get; set; }
        public string TroisiemeNumeroGagnant { get; set; }
        public StatutMiseJoueur StatutMiseJoueur { get; set;}
        public Tirage Tirage { get; set; }
        public ICollection<TransactionCompte> transactionComptes { get; set; }
        public Utilisateur Utilisateur { get; set; }

    }
}
