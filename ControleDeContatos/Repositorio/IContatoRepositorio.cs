﻿using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {        
        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos(int usuarioId);
        ContatoModel Adcionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);


    }
}
