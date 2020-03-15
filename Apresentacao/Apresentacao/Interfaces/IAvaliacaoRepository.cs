using Apresentacao.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apresentacao.Interfaces
{
    interface IAvaliacaoRepository
    {
        /// <summary>
        /// Lista as avaliações de um usuário passando o id
        /// </summary>
        /// <returns>Lista de avaliações de um usuário</returns>
        List<Avaliacao> GetAvaliacoesUsuario(int idUsuario);

        /// <summary>
        /// Lista as avalicaoes referente ao avaliador detentor do id
        /// </summary>
        /// <param name="idAvaliador"></param>
        /// <returns>Lista de avalicaoes referente ao avaliador detentor do id</returns>
        List<Avaliacao> GetAvaliacoesAvaliador(int idAvaliador);
        /// <summary>
        /// Cadastra uma avaliacao
        /// </summary>
        /// <param name="avaliacao"></param>
        void Cadastrar(Avaliacao avaliacao);

        /// <summary>
        /// Altera a avalicao detentora do id
        /// </summary>
        /// <param name="idAvaliacao"></param>
        void Alterar(int idAvaliacao);

        /// <summary>
        /// Excluí a avaliação detentora do id
        /// </summary>
        /// <param name="idAvaliacao"></param>
        void Deletar(int idAvaliacao);
    }
}
