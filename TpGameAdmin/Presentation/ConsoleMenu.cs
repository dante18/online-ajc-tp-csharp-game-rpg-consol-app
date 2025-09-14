using TpGameCore.Model;
using TpGameCore.Presentation;

namespace TpGameAdmin.Presentation;

public class ConsoleMenu
{
    public void AfficherMenuPrincipal()
    {
        Console.WriteLine("1 - Lister les monstres");
        Console.WriteLine("2 - Chercher un monstre");
        Console.WriteLine("3 - Créer un monstre");
        Console.WriteLine("4 - Mettre à jour un monstre");
        Console.WriteLine("5 - Supprimer un monstre");
        Console.WriteLine("6 - Quitter");
        Console.WriteLine("");
    }

    public MonstreModel GestionMenuAjouterMonstre()
    {
        var nom = AppEntry.GetStringEntry("Saisissez le nom du monstre : ");

        if (string.IsNullOrWhiteSpace(nom))
        {
            Random rnd = new Random();
            nom = "monstre" + rnd.Next(1, 100);
        }

        var hp = AppEntry.GetIntegerEntry("Saisissez les HP du monstre : ");
        var attaque = AppEntry.GetIntegerEntry("Saisissez l'attaque du monstre : ");

        return new MonstreModel(nom, hp, attaque);
    }

    public MonstreModel GestionMenuMiseAjourMonstre(MonstreModel monstre)
    {
        Console.WriteLine("Quel champ voulez-vous modifier ?");
        Console.WriteLine("1 - Nom");
        Console.WriteLine("2 - Point de vie");
        Console.WriteLine("3 - Attaque");
        Console.WriteLine("4 - Quitter");
        int choix = AppEntry.GetIntegerEntry("\n");

        if (choix == 1)
        {
            monstre.nom = AppEntry.GetStringEntry("Quel sera le nouveau nom du monstre ?");
        }
        else if (choix == 2)
        {
            monstre.pointDeVie = AppEntry.GetIntegerEntry("Quel sera les nouveaux point de vie ?");
        }
        else if (choix == 2)
        {
            monstre.attaque = AppEntry.GetIntegerEntry("Quel sera les nouveaux point d'attaque ?");
        }

        return monstre;
    }
}
