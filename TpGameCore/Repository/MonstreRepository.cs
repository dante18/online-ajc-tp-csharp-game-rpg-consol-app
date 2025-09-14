using TpGameCore.Context;
using TpGameCore.Entity;
using TpGameCore.Model;

namespace TpGameCore.Repository;

public class MonstreRepository
{
    private readonly TpGameContext _context;

    public MonstreRepository(TpGameContext context)
    {
        _context = context;
    }

    public List<MonstreModel> ObtenirListMonstre()
    {
        return this._context.Monstres.Select(monstre =>
            new MonstreModel(monstre.Nom, monstre.pointDeVie, monstre.attaque)).ToList();
    }

    public MonstreModel ObtenirMonstre(int id)
    {
        return this._context.Monstres.Where(monstre => monstre.Id == id).Select(monstre => new MonstreModel(monstre.Nom, monstre.pointDeVie, monstre.attaque)).FirstOrDefault();
    }

    public int ObtenirNombreDeMonstre()
    {
        return this._context.Monstres.Count();
    }

    public void AjouterMonstre(MonstreModel monstre)
    {
        this._context.Monstres.Add(new Monstre(monstre.nom, monstre.pointDeVie, monstre.attaque));
        this._context.SaveChanges();
    }

    public bool MiseAJourMonstre(int id, MonstreModel monstre)
    {
        var monstreToUpdate = this._context.Monstres.FirstOrDefault(m => m.Id == id);

        if (monstreToUpdate is null)
            return false;

        monstreToUpdate.Nom = monstre.nom;
        monstreToUpdate.attaque = monstre.attaque;
        monstreToUpdate.pointDeVie = monstre.pointDeVie;

        this._context.Monstres.Update(monstreToUpdate);
        this._context.SaveChanges();

        return true;
    }

    public bool SupprimerMonstre(int id)
    {
        var monstreToRemove = this._context.Monstres.FirstOrDefault(m => m.Id == id);

        if (monstreToRemove is null)
            return false;

        this._context.Monstres.Remove(monstreToRemove);
        this._context.SaveChanges();

        return true;
    }
}
