using Microsoft.AspNetCore.Mvc;
using Mundial.BAL.Services.Interfaces;
using Mundial.DAL.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mundial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        public readonly IUsuarios _iusuarios;

        public UsuariosController(IUsuarios iusuario)
        {
            _iusuarios = iusuario;
        }

        // GET: api/<UsuariosController>
        [HttpGet]
        public async Task<IEnumerable<UsuarioDto>> Get()
        {
            return await _iusuarios.GetAll();
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public async Task<UsuarioDto> Get(int id)
        {
            return await _iusuarios.GetUsuarioById(id);
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public async Task<HttpStatusCode> Post(UsuarioDto usuario)
        {
            var res = await _iusuarios.CreateUsuarioAsync(usuario);
            if (res == null)
            {
                return HttpStatusCode.BadRequest;
            }
            else
            {
                return HttpStatusCode.Created;
            }
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public async Task<HttpStatusCode> Put(UsuarioDto usuario)
        {
            var res = await _iusuarios.UpdateUsuarioAsync(usuario);
            if (res == false)
            {
                return HttpStatusCode.BadRequest;
            }
            else
            {
                return HttpStatusCode.OK;
            }
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _iusuarios.DeleteUsuarioAsync(id);
        }
    }
}
