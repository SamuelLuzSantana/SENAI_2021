﻿using Hroads_API.Contexts;
using Hroads_API.Domains;
using Hroads_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hroads_API.Repositories
{
    public class TiposHabilidadesRepository 
    {
        /// <summary>
        /// Objeto contexto(ctx) por onde serão chamados os metodos do EF Core
        /// </summary>
        HROADSContex ctx = new HROADSContex();


        /// <summary>
        /// Lista de todos os tipos de habilidades cadastradas no BD 
        /// </summary>
        /// <returns>Uma Lista de tipos de habilidades</returns>
        List<TiposHabilidade> Listar()
        {
            return ctx.TiposHabilidades.ToList();
        }


        /// <summary>
        /// Busca um tipo de habilidade através do seu id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>um tipo de habilidade buscada</returns>
        TiposHabilidade BuscarPorId(int id)
        {
            //retorna a primeira classe encontrada do id da classe informada
            return ctx.TiposHabilidades.FirstOrDefault(t => t.IdTipo == id);
        }


        /// <summary>
        /// Cadastra um novo tipo de habilidade
        /// </summary>
        /// <param name="novoTipo">Objeto Tipo que sera cadastrado</param>
        void Cadastrar(TiposHabilidade novoTipo)
        {
            //adicona a nova classe
            ctx.TiposHabilidades.Add(novoTipo);
            //salva as informações inseridas no bd
            ctx.SaveChanges();
        }


        /// <summary>
        /// Atualiza um tipo de habilidade existente
        /// </summary>
        /// <param name="id">ID do tipo de habilidade que será atualizada</param>
        /// <param name="tipoAtualizado">Objeto tipoAtualizado com as novas informações</param>
        void Atualizar(int id, TiposHabilidade tipoAtualizado)
        {
            TiposHabilidade tipoBuscado = ctx.TiposHabilidades.Find(id);

            //verifica se o nome do tipo de habilidade foi informado
            if (tipoAtualizado.NomeTipo != null)
            {
                tipoBuscado.NomeTipo = tipoAtualizado.NomeTipo;
            }

            //Atualizo a classe atualizada
            ctx.TiposHabilidades.Update(tipoBuscado);

            //salvo as Mudanças
            ctx.SaveChanges();
        }


        /// <summary>
        /// Deleta uma tipo de habilidade existente 
        /// </summary>
        /// <param name="id">ID do  Tipo de habilidade que será deletada</param>
        void Deletar(int id)
        {

            //busca uma classe pelo seu id
            TiposHabilidade tipoBuscado = ctx.TiposHabilidades.Find(id);

            //remove a classe do bd
            ctx.TiposHabilidades.Remove(tipoBuscado);

            //Salva as mudanças
            ctx.SaveChanges();
        }


    }

}
