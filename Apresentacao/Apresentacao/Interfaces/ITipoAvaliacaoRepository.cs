using Apresentacao.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apresentacao.Interfaces
{
    interface ITipoAvaliacaoRepository
    {
        /// <summary>
        /// Cadastra um tipo de avaliação
        /// </summary>
        /// <param name="tipoAvaliacao"></param>
        void Cadastrar(TipoAvaliacao tipoAvaliacao);
        /// <summary>
        /// Altera um tipo de avaliação - Método não necessário por enquanto
        /// </summary>
        /// <param name="idTipoAvaliacao"></param>
        void Alterar(int idTipoAvaliacao);
        /// <summary>
        /// Deleta um tipo de avaliação através do id fornecido
        /// </summary>
        /// <param name="idTipoAvaliacao"></param>
        void Deletar(int idTipoAvaliacao);
        /// <summary>
        /// Lista todos os tipos de avaliação
        /// </summary>
        /// <returns>Retorna uma lista de tipos de avaliação</returns>
        List<TipoAvaliacao> GetTipoAvaliacoes();

    }
}
