using LOTO_SA_Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO_SA_Library.DAO
{
    public class MiseJoueurDAO : IMiseJoueurDAO
    {
        public DbSet<MiseJoueur> GetAllMiseJoueur()
        {
            return null;
        }

        public void Save(MiseJoueur MiseJoueur)
        {
        }
    }
}
