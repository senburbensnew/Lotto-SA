using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO_SA_Library.Models
{
    public class TypeTransaction
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<TransactionCompte> TransactionsCompte { get; set; }
    }
}
