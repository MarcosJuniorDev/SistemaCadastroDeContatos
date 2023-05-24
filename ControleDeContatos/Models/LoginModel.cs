using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o login do usuario")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha do usuario")]
        public string Senha { get; set; }


    }
}
