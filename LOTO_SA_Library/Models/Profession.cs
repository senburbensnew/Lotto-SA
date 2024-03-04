
namespace LOTO_SA_Library.Models
{
    public class Profession
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public IList<Utilisateur> Utilisateurs { get; set; }
    }
}
