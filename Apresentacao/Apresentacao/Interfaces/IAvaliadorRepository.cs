using Apresentacao.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apresentacao.Interfaces
{
    interface IAvaliadorRepository
    {
        /// <summary>
        /// Cadastra um avaliador
        /// </summary>
        /// <param name="avaliador"></param>
        void Cadastrar(Avaliador avaliador);
        /// <summary>
        /// Altera um avaliador através do id fornecido
        /// </summary>
        /// <param name="idAvaliador"></param>
        void Alterar(int idAvaliador);
        /// <summary>
        /// Deleta um avaliador através do id fornecido
        /// </summary>
        /// <param name="idAvaliador"></param>
        void Deletar(int idAvaliador);

        /// <summary>
        /// Lista todos os avaliadores
        /// </summary>
        /// <returns>Retorna uma lista de avaliadores</returns>
        List<Avaliador> GetAvaliadores();

        /// <summary>
        /// Busca um avaliado através do id fornecido
        /// </summary>
        /// <param name="idAvaliador"></param>
        /// <returns></returns>
        Avaliador GetById(int idAvaliador);
    }
}
