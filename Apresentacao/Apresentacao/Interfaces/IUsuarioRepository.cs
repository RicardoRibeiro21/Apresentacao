using Apresentacao.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apresentacao.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Lista todos os usuários cadastrados com os critérios passados.
        /// </summary>
        /// <returns>Retorna uma lista de usuários</returns>
        List<Usuario> GetUsuarios(string pCrit);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        Usuario GetById(int idUsuario);

        void Cadastrar(Usuario usuario);

        void Deletar(int idUsuario);

        void Alterar(int idUsuario);
    }
}
