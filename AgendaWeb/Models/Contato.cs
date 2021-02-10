using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaWeb.Models
{
    [Table("contatos")]
    public class Contato
    {
        [Key]
        public int contato_id { get; set; }

        [StringLength(30, MinimumLength = 3, ErrorMessage = "Nome deve conter de 3 a 30 caracteres.")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Telefone é obrigatório")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Telefone deve conter pelo menos 3 dígitos")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Telefone deve conter apenas números")]
        public string telefone { get; set; }

        [Display(Name = "Celular")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Celular deve conter pelo menos 3 dígitos")]
        [RegularExpression(@"^^[0-9]*$", ErrorMessage = "Celular deve conter apenas números")]
        public string celular { get; set; }

        [Display(Name = "Endereço")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Endereço deve conter de 3 a 40 caracteres.")]
        public string endereco { get; set; }

        [Display(Name = "Bairro")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Bairro deve conter de 3 a 30 caracteres.")]
        public string bairro { get; set; }

        [Display(Name = "Cidade")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Cidade deve conter de 3 a 30 caracteres.")]
        public string cidade { get; set; }

        [Display(Name = "Estado")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Estado deve conter de 2 a 20 caracteres.")]
        public string estado { get; set; }

        [Display(Name = "CEP")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "CEP deve estar no formato 00000-000")]
        public string cep { get; set; }
    }
}
