using TpGameCore.Abstraction;

namespace TpGameCore.Model;

public abstract class PersonnageModel : IPersonnage
{
    public string nom;

    public int maxHP;

    public int pointDeVie;

    public int attaque;

    public bool isAlive()
    {
        return pointDeVie > 0;
    }

    public void Attaquer(PersonnageModel p)
    {
        Console.WriteLine($"{this.nom} attaque {p.nom} et lui fait perdre {this.attaque} points de vie");
    }

    public void PerdreHP(int atk)
    {
        this.pointDeVie -= atk;
        if (this.pointDeVie < 0)
        {
            this.pointDeVie = 0;
        }
        Console.WriteLine($"{this.nom} : ({this.pointDeVie}/{this.maxHP})");
    }
}
