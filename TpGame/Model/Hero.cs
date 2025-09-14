using TpGameCore.Model;

namespace TpGame.Model;

public class Hero : PersonnageModel
{

    public Hero(string nom, int maxHP, int attaque)
    {
        this.nom = nom;
        this.maxHP = maxHP;
        this.pointDeVie = maxHP;
        this.attaque = attaque;
    }

    public bool Potion { get; set; } = true;

    public void RegenHP()
    {
        pointDeVie = maxHP;
        Potion = false;
    }

    public bool HasPotion()
    {
        return Potion;
    }
}
