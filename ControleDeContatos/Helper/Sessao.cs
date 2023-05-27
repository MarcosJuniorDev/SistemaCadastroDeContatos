﻿using ControleDeContatos.Models;
using Newtonsoft.Json;

namespace ControleDeContatos.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public Sessao(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public UsuarioModel BuscarSessaoUsuario()
        {
            string sessaoUsuario = _contextAccessor.HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);

        }

        public void CriarSessaoUsuario(UsuarioModel usuario)
        {
            //converter o obj usuario para string para armazenar no httpcontext
            string valor = JsonConvert.SerializeObject(usuario);
            _contextAccessor.HttpContext.Session.SetString("sessaoUsuarioLogado", valor);
        }

        public void RemoverSessaoUsuario()
        {
            _contextAccessor.HttpContext.Session.Remove("sessaoUsuarioLogado");
        }
    }
}
