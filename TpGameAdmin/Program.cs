using TpGameAdmin.Presentation;
using TpGameCore.Context;
using TpGameCore.Model;
using TpGameCore.Presentation;
using TpGameCore.Repository;

Console.WriteLine("Bienvenue dans la gestion des monstres");
Console.WriteLine("");

int choix;
ConsoleMenu consoleMenu = new ConsoleMenu();

using var context = new TpGameContext();
MonstreRepository repository = new MonstreRepository(context);
int nombreMonstre = repository.ObtenirNombreDeMonstre();

do
{
    consoleMenu.AfficherMenuPrincipal();

    choix = AppEntry.GetIntegerEntry("Que souhaitez-vous faire ?");
    Console.Clear();
    Console.WriteLine("");

    switch (choix)
    {
        case 1:
            if (nombreMonstre > 0)
            {
                List<MonstreModel> monstres = repository.ObtenirListMonstre();

                foreach (var monstre in monstres)
                {
                    Console.WriteLine(monstre);
                }

                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Aucun monstre");
                Console.WriteLine("");
            }
            break;
        case 2:
            if (nombreMonstre > 0)
            {
                int choixMonstre = AppEntry.GetIntegerEntry("Quel monstre voulez-vous regarder ?");
                MonstreModel monstreAConsulter = repository.ObtenirMonstre(choixMonstre);
                Console.WriteLine("");

                if (monstreAConsulter is null)
                {
                    Console.WriteLine("Le monstre n'existe pas");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(monstreAConsulter);
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Aucun monstre");
                Console.WriteLine("");
            }
            break;
        case 3:
            repository.AjouterMonstre(consoleMenu.GestionMenuAjouterMonstre());
            Console.WriteLine("");
            nombreMonstre = repository.ObtenirNombreDeMonstre();
            break;
        case 4:
            if (nombreMonstre > 0)
            {
                int choixMonstreAMettreAJour = AppEntry.GetIntegerEntry("Quel monstre voulez-vous modifier ?");
                MonstreModel monstreAMettreAJour = repository.ObtenirMonstre(choixMonstreAMettreAJour);
                Console.WriteLine("");

                if (monstreAMettreAJour is null)
                {
                    Console.WriteLine("Le monstre n'existe pas");
                    Console.WriteLine("");
                }
                else
                {
                    monstreAMettreAJour = consoleMenu.GestionMenuMiseAjourMonstre(monstreAMettreAJour);
                    Console.WriteLine("");

                    bool monstreAMettreAJourResultat = repository.MiseAJourMonstre(choixMonstreAMettreAJour, monstreAMettreAJour);

                    if (monstreAMettreAJourResultat)
                    {
                        Console.WriteLine("Le monstre a été mis à jour");
                    }

                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Aucun monstre");
                Console.WriteLine("");
            }
            break;
        case 5:
            if (nombreMonstre > 0)
            {
                int choixMonstreASupprimer = AppEntry.GetIntegerEntry("Quel monstre voulez-vous supprimer ?");
                MonstreModel monstreASupprimer = repository.ObtenirMonstre(choixMonstreASupprimer);
                Console.WriteLine("");

                if (monstreASupprimer is null)
                {
                    Console.WriteLine("Le monstre n'existe pas");
                    Console.WriteLine("");
                }
                else
                {
                    bool monstreASupprimerResultat = repository.SupprimerMonstre(choixMonstreASupprimer);

                    if (monstreASupprimerResultat)
                    {
                        Console.WriteLine("Le monstre a été supprimé");
                    }

                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Aucun monstre");
                Console.WriteLine("");
            }
            break;
        case 6:
            break;
    }
} while (choix != 6);