namespace TpGameCore.Model;

public class MonstreModel : PersonnageModel
{
    public MonstreModel(string nom, int maxHP, int attaque)
    {
        this.nom = nom;
        this.maxHP = maxHP;
        this.pointDeVie = maxHP;
        this.attaque = attaque;
    }

    public override string ToString()
    {
        return $"Nom : {this.nom}\t\tHP : {this.pointDeVie} pts de vie\t\tAttaque : {this.attaque}";
    }
}
