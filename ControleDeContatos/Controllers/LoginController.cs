using ControleDeContatos.Models;
using ControleDeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.Login);


                    if (usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensagemErro"] = $"Usuario e/ou senha invalidos, tente novamente.";

                    }
                    TempData["MensagemErro"] = $"Usuario e/ou senha invalidos, tente novamente.";
                }

                return View("Index");
            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamente, detalhe do erro: {e.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
