using ControleDeContatos.Models;

namespace ControleDeContatos.Helper
{
    public interface ISessao
    {
        public void CriarSessaoUsuario(UsuarioModel usuario);
        public void RemoverSessaoUsuario();
        public UsuarioModel BuscarSessaoUsuario();



    }
}
