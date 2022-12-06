using Mundial.DAL.Entities;
using Mundial.DAL.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mundial.BAL.Entitys.Interfaces
{
    public interface IResultados
    {
        Task<IEnumerable<ResultadoDto>> GetAll();
        Task<ResultadoDto> GetResultadoById(int id);
        Task<ResultadoDto> CreateResultadoAsync(ResultadoDto resultado);
        Task<bool> UpdateResultadoAsync(ResultadoDto resultado);
        Task<bool> DeleteResultadoAsync(int id);
    }
}
