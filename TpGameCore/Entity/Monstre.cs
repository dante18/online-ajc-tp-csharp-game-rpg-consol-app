namespace TpGameCore.Entity;

public class Monstre : APersonnage
{
    public Monstre() { }

    public Monstre(string nom, int pointDeVie, int attaque)
    {
        this.Nom = nom;
        this.pointDeVie = pointDeVie;
        this.attaque = attaque;
    }
}
