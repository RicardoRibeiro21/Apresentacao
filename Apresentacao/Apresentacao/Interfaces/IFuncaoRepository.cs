using Apresentacao.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apresentacao.Interfaces
{
    interface IFuncaoRepository
    {
        /// <summary>
        /// Cadastra uma funcao de avaliador
        /// </summary>
        /// <param name="funcao"></param>
        void Cadastrar(Funcao funcao);
        /// <summary>
        /// Deleta uma funcao através do id fornecido
        /// </summary>
        /// <param name="idFuncao"></param>
        void Deletar(int idFuncao);
        /// <summary>
        /// Alterar uma funcao através do id fornecido
        /// </summary>
        /// <param name="idFuncao"></param>
        void Alterar(int idFuncao);
        /// <summary>
        /// Lista todas as funcoes dependendo do critério fornecido
        /// </summary>
        /// <param name="pCrit"></param>
        /// <returns>Uma lista de Funcoes que atendem o criterio</returns>
        List<Funcao> GetFuncoes(string pCrit);
    }
}
