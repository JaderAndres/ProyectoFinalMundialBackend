using Microsoft.AspNetCore.Mvc;
using Mundial.BAL.Entitys.Interfaces;
using Mundial.BAL.Services.Interfaces;
using Mundial.DAL.Entities;
using Mundial.DAL.Entities.DTOs;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mundial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultadosController : ControllerBase
    {
        public readonly IResultados _iresultados;

        public ResultadosController(IResultados iresultados)
        {
            _iresultados = iresultados;
        }

        // GET: api/<ResultadosController>
        [HttpGet]
        public async Task<IEnumerable<ResultadoDto>> Get()
        {
            return await _iresultados.GetAll();
        }

        // GET api/<ResultadosController>/5
        [HttpGet("{id}")]
        public async Task<ResultadoDto> Get(int id)
        {
            return await _iresultados.GetResultadoById(id);
        }

        // POST api/<ResultadosController>
        [HttpPost]
        public async Task<HttpStatusCode> Post(ResultadoDto resultado)
        {
            var res = await _iresultados.CreateResultadoAsync(resultado);
            if (res == null)
            {
                return HttpStatusCode.BadRequest;
            }
            else
            {
                return HttpStatusCode.Created;
            }
        }

        // PUT api/<ResultadosController>/5
        [HttpPut("{id}")]
        public async Task<HttpStatusCode> Put(ResultadoDto usuario)
        {
            var res = await _iresultados.UpdateResultadoAsync(usuario);
            if (res == false)
            {
                return HttpStatusCode.BadRequest;
            }
            else
            {
                return HttpStatusCode.OK;
            }
        }

        // DELETE api/<ResultadosController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _iresultados.DeleteResultadoAsync(id);
        }
    }
}
