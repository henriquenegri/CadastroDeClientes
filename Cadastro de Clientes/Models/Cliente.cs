using System.ComponentModel.DataAnnotations;

namespace Cadastro_de_Clientes.Models;

public class Cliente
{
    [Key]
    public long Id { get; set; }

    [Required]
    [Display(Name = "Nome Do cliente")]
    public string Nome { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "E-mail")]
    public string email { get; set; }

    [Required]
    [Phone]
    public int Telefone { get; set; }

    [Required]
    [StringLength(100)]
    [Display(Name = "Rua")]
    public string Logradouro { get; set; }

    [Required]
    [StringLength(100)]
    public string Bairro { get; set; }

    [Required]
    [Display(Name = "Número")]
    public int Numero { get; set; }

    [Required]
    [StringLength(100)]
    public string Cidade { get; set; }

    [Required]
    [StringLength(100)]
    public string Estado { get; set; }
}
