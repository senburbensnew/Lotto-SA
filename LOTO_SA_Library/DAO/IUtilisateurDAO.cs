using LOTO_SA_Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO_SA_Library.DAO
{
    public interface IUtilisateurDAO
    {
        DbSet<Utilisateur> GetAllUtilisateurs();
        void Save(Utilisateur utilisateur);
    }
}
