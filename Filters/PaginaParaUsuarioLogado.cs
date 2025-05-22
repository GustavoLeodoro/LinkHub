using LinkHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace LinkHub.Filters
{
    public class PaginaParaUsuarioLogado : ActionFilterAttribute
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
            }

            base.OnActionExecuted(context);
        }
    }
}
