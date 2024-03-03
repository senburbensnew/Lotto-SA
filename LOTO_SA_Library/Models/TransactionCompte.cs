using LOTO_SA_Library.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO_SA_Library.Models
{
    public class TransactionCompte
    {
        public int Id { get; set; }
        public double Montant { get; set; }
        public string? Description { get; set; }
        public DateTime DateTransaction { get; set; }
        public SensTransaction SensTransaction { get; set; }
        public TypeTransaction TypeTransaction { get; set; }
        public MiseJoueur MiseJoueur { get; set;}
    }
}
