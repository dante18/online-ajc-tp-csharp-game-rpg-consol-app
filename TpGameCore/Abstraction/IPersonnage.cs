using TpGameCore.Model;

namespace TpGameCore.Abstraction;

internal interface IPersonnage
{
    public void Attaquer(PersonnageModel p);

    public void PerdreHP(int atk);
}