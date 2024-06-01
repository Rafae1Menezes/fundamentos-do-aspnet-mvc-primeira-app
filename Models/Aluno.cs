using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiraApp.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo {0} está em formato incorreto")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres")]
        [EmailAddress(ErrorMessage = "O campo {0} está no formato inválido.")]
        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Confirme o e-mail")]
        [Compare("Email", ErrorMessage = "Os e-mails informados não são idênticos")]
        [NotMapped]
        public string? EmailConfirmacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1,5, ErrorMessage = "O campo {0} deve estar entre {2} e {1}")]
        public int Avaliacao { get; set; }


        public bool Ativo {  get; set; }
    }
}
