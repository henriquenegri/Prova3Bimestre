using System.ComponentModel.DataAnnotations;

namespace Prova3Bimestre.Models;

public class Fornecedor
{
    [Key]
    public long Id { get; set; }

    [Required]
    public string Nome { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "E-mail")]
    public string email { get; set; }

    [Required]
    public int CNPJ { get; set; }

    [Required]
    public int Telefone { get; set; }
}
