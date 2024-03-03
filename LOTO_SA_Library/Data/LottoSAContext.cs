using LOTO_SA_Library.Models;
using Microsoft.EntityFrameworkCore;

namespace LOTO_SA_Library.Data
{
    public class LottoSAContext : DbContext
    {
        public DbSet<MiseJoueur> MiseJoueurs { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Tirage> Tirages { get; set; }
        public DbSet<TransactionCompte> TransactionComptes { get; set; }
        public DbSet<TypeTransaction> TypeTransactions { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=DESKTOP-RLMJ3NG;Database=lotto_sa_db;User Id=sa;Password=Newbensur3190#;TrustServerCertificate=True;");
        }
    }
}
