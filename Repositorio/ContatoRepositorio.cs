using LinkHub.Data;
using LinkHub.Models;

namespace LinkHub.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {

        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;

        }

        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos(int usuarioId)
        {
            return _bancoContext.Contatos.Where(x => x.UsuarioId == usuarioId).ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            contato.DataCadastro = DateTime.Now;
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);
            if (contatoDB == null) throw new System.Exception("Houve um erro na atualização do contato");
            contatoDB.Nome = contato.Nome;
            contatoDB.Sobrenome = contato.Sobrenome;
            contatoDB.Endereco = contato.Endereco;
            contatoDB.Celular = contato.Celular;
            contatoDB.Cep = contato.Cep;
            contatoDB.Email = contato.Email;
            contatoDB.DataAtualizacao = DateTime.Now;

            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();
            return contatoDB;

        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);
            if (contatoDB == null) throw new System.Exception("Houve um erro na deleção do contato");
            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
