using Microsoft.EntityFrameworkCore;
using Mundial.BAL.Entitys.Interfaces;
using Mundial.DAL.Entities;
using Mundial.DAL.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundial.BAL.Entities.Repositorio
{
    public class RepositorioResultado : IResultados
    {

        #region Propiedades - Constructor
        private readonly MundialContext _context;

        public RepositorioResultado(MundialContext context)
        {
            _context = context;
        }
        #endregion


        public async Task<ResultadoDto> CreateResultadoAsync(ResultadoDto resultado)
        {
            try
            {
                var entidad = new Resultado()
                {
                    EquipoId = resultado.EquipoId,
                    GolesaFavor = resultado.GolesaFavor,
                    GolesenContra = resultado.GolesenContra,
                    NumeroPartido = resultado.NumeroPartido
                };

                _context.Add(entidad);
                await _context.SaveChangesAsync();

                return resultado;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public async Task<bool> DeleteResultadoAsync(int id)
        {
            try
            {
                var entity = new Resultado()
                {
                    ResultadoId = id
                };
                _context.Resultado.Attach(entity);
                _context.Resultado.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<ResultadoDto>> GetAll()
        {
            try
            {
                var _resultado = await _context.Resultado.Select(r => new ResultadoDto()
                {
                    ResultadoId = r.ResultadoId,
                    GolesaFavor = r.GolesaFavor,
                    GolesenContra = r.GolesenContra,
                    NumeroPartido = r.NumeroPartido,
                    EquipoId = r.EquipoId,
                    NombreEquipo = r.Equipo.Nombre,
                }).ToListAsync();
                return _resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ResultadoDto> GetResultadoById(int id)
        {
            try
            {
                var resultado = await _context.Resultado.Select(r => new ResultadoDto()
                {
                    ResultadoId = r.ResultadoId,                    
                    GolesaFavor = r.GolesaFavor,
                    GolesenContra = r.GolesenContra,                    
                    NumeroPartido = r.NumeroPartido,
                    EquipoId = r.EquipoId,
                    NombreEquipo = r.Equipo.Nombre
                }).FirstOrDefaultAsync(r => r.ResultadoId == id);
                return resultado;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdateResultadoAsync(ResultadoDto resultado)
        {
            try
            {
                var entidad = await _context.Resultado.FirstOrDefaultAsync(e => e.ResultadoId == resultado.ResultadoId);
                entidad.GolesaFavor = resultado.GolesaFavor;
                entidad.GolesenContra = resultado.GolesenContra;
                entidad.NumeroPartido = resultado.NumeroPartido;
                entidad.EquipoId = resultado.EquipoId;
                     
                _context.Entry(entidad).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}

