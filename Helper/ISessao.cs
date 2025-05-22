using LinkHub.Models;

namespace LinkHub.Helper
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(UsuarioModel usuario);
        void RemoverSessaoDoUsuario();

        UsuarioModel BuscarSessaoDoUsuario();
    }
}
