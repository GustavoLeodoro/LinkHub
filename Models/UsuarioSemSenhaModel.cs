using LinkHub.Enum;
using System.ComponentModel.DataAnnotations;

namespace LinkHub.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Login é obrigatório.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo Email não é um e-mail válido.")]

        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Perfil é obrigatório.")]

        public PerfilEnum? Perfil { get; set; }

        
    }
}
