using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LOTO_SA_Library.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tirages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    coefficientPremierNumeroGagnant = table.Column<float>(type: "real", nullable: false),
                    coefficientSecondNumeroGagnant = table.Column<float>(type: "real", nullable: false),
                    coefficientTroisiemeNumeroGagnant = table.Column<float>(type: "real", nullable: false),
                    PremierNumeroGagnant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondNumeroGagnant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TroisiemeNumeroGagnant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatutTirage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tirages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeTransactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeUtilisateur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotDePasse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profil = table.Column<int>(type: "int", nullable: false),
                    StatutUtilisateur = table.Column<int>(type: "int", nullable: false),
                    ProfessionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utilisateurs_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MiseJoueurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MisePremierNumeroGagnant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiseSecondNumeroGagnant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiseTroisiemeNumeroGagnant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MontantGagne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PremierNumeroGagnant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondNumeroGagnant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TroisiemeNumeroGagnant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatutMiseJoueur = table.Column<int>(type: "int", nullable: false),
                    TirageId = table.Column<int>(type: "int", nullable: false),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiseJoueurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MiseJoueurs_Tirages_TirageId",
                        column: x => x.TirageId,
                        principalTable: "Tirages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MiseJoueurs_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionComptes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Montant = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTransaction = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SensTransaction = table.Column<int>(type: "int", nullable: false),
                    TypeTransactionId = table.Column<int>(type: "int", nullable: false),
                    MiseJoueurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionComptes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionComptes_MiseJoueurs_MiseJoueurId",
                        column: x => x.MiseJoueurId,
                        principalTable: "MiseJoueurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionComptes_TypeTransactions_TypeTransactionId",
                        column: x => x.TypeTransactionId,
                        principalTable: "TypeTransactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MiseJoueurs_TirageId",
                table: "MiseJoueurs",
                column: "TirageId");

            migrationBuilder.CreateIndex(
                name: "IX_MiseJoueurs_UtilisateurId",
                table: "MiseJoueurs",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionComptes_MiseJoueurId",
                table: "TransactionComptes",
                column: "MiseJoueurId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionComptes_TypeTransactionId",
                table: "TransactionComptes",
                column: "TypeTransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_ProfessionId",
                table: "Utilisateurs",
                column: "ProfessionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionComptes");

            migrationBuilder.DropTable(
                name: "MiseJoueurs");

            migrationBuilder.DropTable(
                name: "TypeTransactions");

            migrationBuilder.DropTable(
                name: "Tirages");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Professions");
        }
    }
}
