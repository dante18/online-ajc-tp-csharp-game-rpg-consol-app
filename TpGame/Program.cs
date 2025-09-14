using TpGame.Model;
using TpGameCore.Context;
using TpGameCore.Model;
using TpGameCore.Repository;

bool partieEstPerdu = false;

using var context = new TpGameContext();
MonstreRepository repository = new MonstreRepository(context);
List<MonstreModel> monstres = repository.ObtenirListMonstre();

Hero hero = new Hero("Michel", 1200, 75);

while (hero.isAlive() && monstres.Count > 0)
{
    MonstreModel monstre = monstres[0];
    Console.WriteLine($"Un terrible {monstre.nom} est apparu !");

    while (monstre.isAlive())
    {
        Console.WriteLine($"\nC'est au tour de {hero.nom} !");
        Console.WriteLine("Que souhaitez vous faire ?");
        Console.WriteLine("1. Attaquer");
        if (hero.HasPotion() is true)
        {
            Console.WriteLine("2. Me soigner");
        }

        Console.WriteLine("");
        string? choixHero = Console.ReadLine();
        switch (choixHero)
        {
            case "1":
                hero.Attaquer(monstre);
                monstre.PerdreHP(hero.attaque);
                break;

            case "2":
                if (hero.HasPotion() is false)
                {
                    Console.WriteLine("Ce choix n'est pas disponible.");
                    continue;
                }
                hero.RegenHP();
                break;

            default:
                Console.WriteLine("Ce choix n'est pas disponible.");
                continue;
        }

        if (monstre.isAlive() is false)
        {
            Console.WriteLine($"Vous avez héroïquement triomphé du sombre {monstre.nom}.\n");

            // supprimer le monstre de la liste
            monstres.Remove(monstre);
            break;
        }
        else
        {
            monstre.Attaquer(hero);
            hero.PerdreHP(monstre.attaque);

            if (hero.isAlive() is false)
            {
                partieEstPerdu = true;
                break;
            }
        }
    }
}

if (partieEstPerdu)
{
    Console.WriteLine("Vous avez perdu la partie !");
}
else
{
    Console.WriteLine("Félicitations, vous avez remporté la partie !");
}
