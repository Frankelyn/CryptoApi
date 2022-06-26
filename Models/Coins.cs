using System.ComponentModel.DataAnnotations;

public class Coins
{
    [Key]
    public int MonedaId { get; set; }
    public string? Descripcion { get; set; }
    public double Valor { get; set; }
    public string? ImageUrl { get; set; }

}