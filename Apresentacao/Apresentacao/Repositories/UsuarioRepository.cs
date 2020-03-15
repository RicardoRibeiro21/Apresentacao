using Apresentacao.Domains;
using Apresentacao.Interfaces;
using Apresentacao.services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apresentacao.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        Conexao con = new Conexao();
        public void Alterar(int idUsuario)
        {
            try
            {
                string conexao = con.StringConexao.ToString();
                string query = "UPDATE usuario SET nome_usuario = @nome_usuario, idade_usuario = @idade_usuario, email_usuario = @email_usuario, senha_usuario =  @senha_usuario" +
                               "WHERE id_usuario = @id_usuario;";

                Usuario usuario = GetById(idUsuario);

                if (usuario != null)
                {
                    using (SqlConnection con = new SqlConnection(conexao))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id_usuario", usuario.IdUsuario);
                        cmd.Parameters.AddWithValue("@idade_usuario", usuario.IdadeUsuario);
                        cmd.Parameters.AddWithValue("@email_usuario", usuario.EmailUsuario);
                        cmd.Parameters.AddWithValue("@senha_usuario", usuario.SenhaUsuario);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                string conexao = con.StringConexao.ToString();
                string query = "INSERT INTO usuario (nome_usuario, idade_usuario, email_usuario, senha_usuario )" +
                               "     VALUES (@nome_usuario, @idade_usuario, @email_usuario, @senha_usuario);";

                using (SqlConnection con = new SqlConnection(conexao))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nome_usuario", usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@idade_usuario", usuario.IdadeUsuario);
                    cmd.Parameters.AddWithValue("@email_usuario", usuario.EmailUsuario);
                    cmd.Parameters.AddWithValue("@senha_usuario", usuario.SenhaUsuario);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public void Deletar(int idUsuario)
        {
            try
            {
                string conexao = con.StringConexao.ToString();
                string query = "DELETE FROM usuario WHERE id_usuario = @id_usuario;";

                Usuario usuario = GetById(idUsuario);

                if (usuario != null)
                {
                    using (SqlConnection con = new SqlConnection(conexao))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id_usuario", usuario.IdUsuario);
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public Usuario GetById(int idUsuario)
        {
            try
            {
                string conexao = con.StringConexao.ToString();
                string query = "SELECT id_usuario, nome_usuario, idade_usuario, email_usuario, idade_usuario, email_usuario, senha_usuario " +
                    "             FROM usuario " +
                    "            WHERE id_usuario = @id_usuario";

                using (SqlConnection con = new SqlConnection(conexao))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_usuario", idUsuario);

                        SqlDataReader sqr = cmd.ExecuteReader();
                        if (sqr.HasRows)
                        {
                            while (sqr.Read())
                            {
                                Usuario usuario = new Usuario()
                                {
                                    IdUsuario = Convert.ToInt32(sqr["id_usuario"]),
                                    NomeUsuario = sqr["nome_usuario"].ToString(),
                                    SenhaUsuario = sqr["senha_usuario"].ToString(),
                                    IdadeUsuario = Convert.ToInt32(sqr["idade_usuario"]),
                                    EmailUsuario = sqr["email_usuario"].ToString()
                                };
                                return usuario;
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Usuario> GetUsuarios(string pCrit)
        {
            try
            {
                string conexao = con.StringConexao.ToString();
                string query = "SELECT id_usuario, nome_usuario, idade_usuario, email_usuario, idade_usuario, email_usuario, senha_usuario FROM usuario";

                List<Usuario> listUsuarios = new List<Usuario>();

                using (SqlConnection con = new SqlConnection(conexao))
                {
                    con.Open();


                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader sqr = cmd.ExecuteReader();
                        if (sqr.HasRows)
                        {
                            while (sqr.Read())
                            {
                                Usuario usuario = new Usuario()
                                {
                                    IdUsuario = Convert.ToInt32(sqr["id_usuario"]),
                                    NomeUsuario = sqr["nome_usuario"].ToString(),
                                    SenhaUsuario = sqr["senha_usuario"].ToString(),
                                    IdadeUsuario = Convert.ToInt32(sqr["idade_usuario"]),
                                    EmailUsuario = sqr["email_usuario"].ToString()
                                };
                                listUsuarios.Add(usuario);
                            }
                        }
                    }
                }
                return listUsuarios;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
