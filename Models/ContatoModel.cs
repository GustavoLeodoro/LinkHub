using System.ComponentModel.DataAnnotations;

namespace LinkHub.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Sobrenome é obrigatório.")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo Email não é um e-mail válido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Celular é obrigatório.")]
        [Phone(ErrorMessage = "O campo Celular não é um número válido.")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "O campo Cep é obrigatório.")]
        public string Cep { get; set; }

        public DateTime? DataCadastro { get; set; }

        public DateTime? DataAtualizacao { get; set; }


        public int? UsuarioId { get; set; }

        public UsuarioModel? Usuario { get; set; }

    }
}
