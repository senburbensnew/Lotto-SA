using LOTO_SA_Library.Data;
using LOTO_SA_Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO_SA_Library.DAO
{
    public class UtilisateurDAO : IUtilisateurDAO
    {

        private readonly LottoSAContext _context;

        public UtilisateurDAO()
        {
            _context = new LottoSAContext();
        }


        public DbSet<Utilisateur> GetAllUtilisateurs()
        {
            return _context.Utilisateurs;
        }

        public void Save(Utilisateur utilisateur)
        {
            _context.Utilisateurs.Add(utilisateur);
            _context.SaveChanges();
        }
    }
}
