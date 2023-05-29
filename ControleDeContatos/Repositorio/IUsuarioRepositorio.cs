using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IUsuarioRepositorio
    {

        UsuarioModel BuscarPorLogin(string login);
        UsuarioModel BuscarPorEmailELogin(string email, string login);
        UsuarioModel ListarPorId(int id);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adcionar(UsuarioModel contato);
        UsuarioModel Atualizar(UsuarioModel contato);
        UsuarioModel AlterarSenha(AlterarSenhaModel alterarSenha);
        bool Apagar(int id);



    }
}
