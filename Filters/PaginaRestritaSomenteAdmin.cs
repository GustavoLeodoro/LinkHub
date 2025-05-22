using LinkHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace LinkHub.Filters
{
    public class PaginaRestritaSomenteAdmin : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            // Verifica se o usuário está logado
            string? sessaoUsuario = context.HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario))
            {
                // Se não estiver logado, redireciona para a página de login
                context.Result = new RedirectToActionResult("Index", "Login", null);
            }
            else
            {
                UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);
                // Verifica se o usuário é nulo ou se o ID é inválido
                if(usuario == null)
                {
                    context.Result = new RedirectToActionResult("Index", "Login", null);
                }
                if (usuario.Perfil != Enum.PerfilEnum.Administrador &&
                        usuario.Perfil != Enum.PerfilEnum.Gestor &&
                        usuario.Perfil != Enum.PerfilEnum.Supervisor)
                {
                    context.Result = new RedirectToActionResult("Index", "Restrito", null);
                }

            }

            base.OnActionExecuted(context);
        }
    }
}
