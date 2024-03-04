using LOTO_SA_Library.Models.Enums;

namespace LOTO_SA_Library.Models
{
    public class Utilisateur
    {

        public Utilisateur() {
            MiseJoueurs = new List<MiseJoueur>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public string CodeUtilisateur { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public string Nif { get; set; }
        public Profil Profil { get; set; }
        public StatutUtilisateur StatutUtilisateur { get; set; }
        public Profession Profession { get; set; }
        public IList<MiseJoueur> MiseJoueurs { get; set; }
    }
}
