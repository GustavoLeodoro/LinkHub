using LinkHub.Enum;
using LinkHub.Helper;
using System.ComponentModel.DataAnnotations;

namespace LinkHub.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Login é obrigatório.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O campo senha é obrigatório.")]

        public string Senha { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo Email não é um e-mail válido.")]

        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Perfil é obrigatório.")]

        public PerfilEnum? Perfil { get; set; }

        public DateTime? DataCadastro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public virtual List<ContatoModel> Contatos { get; set; }

        public bool SenhaValida(string senha)
        {
            
            return Senha == senha.GerarHash();
        }

        public void SetSenhaHash()
        {
            Senha = Senha.GerarHash();
        }

        public string GerarNovaSenha()
        {
            string novaSenha = Guid.NewGuid().ToString().Substring(0, 8);
            Senha = novaSenha.GerarHash();
            return novaSenha;
        }

        public void SetNovaSenha(string novaSenha)
        {
            Senha = novaSenha.GerarHash();
        }

    }
}
