using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaWeb.Models
{
    [Table("contatos")]
    public class Contato
    {
        [Key]
        public int Contato_id { get; set; }

        [StringLength(30, MinimumLength = 3, ErrorMessage = "Nome deve conter de 3 a 30 caracteres.")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [StringLength(30, MinimumLength = 1)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Endereço")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Endereço deve conter de 3 a 40 caracteres.")]
        public string Endereco { get; set; }

        [Display(Name = "Número")]
        public string Numero { get; set; }

        [Display(Name = "Bairro")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Bairro deve conter de 3 a 30 caracteres.")]
        public string Bairro { get; set; }

        [Display(Name = "Cidade")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Cidade deve conter de 3 a 30 caracteres.")]
        public string Cidade { get; set; }

        [Display(Name = "CEP")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "CEP deve estar no formato 00000-000")]
        public string Cep { get; set; }


        [Display(Name = "Telefone Residencial")]
        public string TelefoneRes { get; set; }


        [Display(Name = "Telefone Comercial")]
        public string TelefoneCom { get; set; }

        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [Display(Name = "Outro")]
        public string OutroNum { get; set; }

        [Display(Name = "Telefone 0800")]
        public string Telefone0800 { get; set; }

        [Display(Name = "Informações adicionais")]
        public string Informacoes { get; set; }


    }
}
