using System.ComponentModel.DataAnnotations;
namespace Avalicao.Models;


    public class CadastroCliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Este endereço de e-mail não é válido.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [Phone(ErrorMessage = "Este telefone não é válido.")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [Display(Name = "CEP")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "O CEP inserido não é válido. Utilize o formato 00000-000.")]
        public string Cep { get; set; } // Alterado para Cep

        [Required(ErrorMessage = "A rua é obrigatória.")]
        [Display(Name = "Rua")]
        public string Rua { get; set; } // Alterado para Rua

        [Required(ErrorMessage = "O número é obrigatório.")]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O bairro é obrigatório.")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; } // Alterado para Bairro

        [Required(ErrorMessage = "A cidade é obrigatória.")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; } // Alterado para Cidade

        [Required(ErrorMessage = "O estado é obrigatório.")]
        [Display(Name = "Estado")]
        public string Estado { get; set; } // Alterado para Estado
    }




