using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apresentacao.Domains;
using Apresentacao.Interfaces;
using Apresentacao.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apresentacao.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository UsuarioRepository { get; set; }

        public UsuarioController()
        {
            UsuarioRepository = new UsuarioRepository();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int idUsuario)
        {
            try
            {
                return Ok(UsuarioRepository.GetById(idUsuario));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get (string pCrit)
        {
            try
            {
                return Ok(UsuarioRepository.GetUsuarios(pCrit));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpPost]
        public IActionResult Post (Usuario usuario)
        {
            try
            {
                UsuarioRepository.Cadastrar(usuario);
                return Ok();
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }


        [HttpPut]
        public IActionResult Put (int idUsuario)
        {
            try
            {
                UsuarioRepository.Alterar(idUsuario);
                return Ok();
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [HttpDelete]
        public IActionResult Delete (int idUsuario)
        {
            try
            {
                UsuarioRepository.Deletar(idUsuario);
                return Ok();
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}