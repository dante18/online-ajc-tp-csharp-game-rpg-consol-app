using System.ComponentModel.DataAnnotations;

namespace TpGameCore.Entity;

public abstract class APersonnage
{
    public int Id { get; set; }

    [Required]
    public int pointDeVie { get; set; }

    [Required]
    [MaxLength(150)]
    public string Nom { get; set; } = string.Empty;

    [Required]
    public int attaque { get; set; }
}
