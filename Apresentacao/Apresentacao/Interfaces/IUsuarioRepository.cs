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
        /// Busca um usuário pelo id passado como parâmetro
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>Retorna um Objeto Usuario</returns>
        Usuario GetById(int idUsuario);
        /// <summary>
        /// Cadastra um novo usuario
        /// </summary>
        /// <param name="usuario"></param>
        void Cadastrar(Usuario usuario);

        /// <summary>
        /// Deleta um usuário a partir do id fornecido
        /// </summary>
        /// <param name="idUsuario"></param>
        void Deletar(int idUsuario);

        /// <summary>
        /// Altera um usuário a partir do id fornecido
        /// </summary>
        /// <param name="idUsuario"></param>
        void Alterar(int idUsuario);
    }
}
