using LOTO_SA_Library.DAO;
using LOTO_SA_Library.Models;
using LOTO_SA_Library.Models.Enums;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        IUtilisateurDAO utilisateurDAO = new UtilisateurDAO();
        Utilisateur utilisateur = new Utilisateur()
        {
            Nom = "Nom",
            Prenom = "Prenom",
            Sexe  = "Sexe",
            CodeUtilisateur = "CodeUtilisateur",
            DateNaissance = (new DateTime()),
            Email = "Email",
            MotDePasse = "MotDePasse",
            Nif = "Nif",
            Profil = Profil.Manager,
            StatutUtilisateur = StatutUtilisateur.Actif,
            Profession = new Profession() { Libelle = "Informaticien"}
        };

        utilisateurDAO.Save(utilisateur);
        DbSet<Utilisateur> utilisateurs = utilisateurDAO.GetAllUtilisateurs();
    }
}