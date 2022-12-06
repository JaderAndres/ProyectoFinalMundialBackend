using Microsoft.EntityFrameworkCore;
using Mundial.BAL.Services.Interfaces;
using Mundial.DAL.Entities;
using Mundial.DAL.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundial.BAL.Services.Repositorios
{
    public class RepositorioUsuario : IUsuarios
    {
        #region Propiedades - Constructor
        private readonly MundialContext _context;

        public RepositorioUsuario(MundialContext context)
        {
            _context = context;
        }
        #endregion

        #region Crear repositorio Usuario

        /// <summary>
        /// Crear del repositorio Usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public async Task<UsuarioDto> CreateUsuarioAsync(UsuarioDto usuario)
        {
            try
            {
                var entidad = new Usuario()
                {
                    Nombre = usuario.Nombre,
                    Clave = usuario.Clave,
                    Tipo = usuario.Tipo
                };

                _context.Add(entidad);
                await _context.SaveChangesAsync();

                return usuario;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        #endregion

        #region Delete repositorio Usuario

        /// <summary>
        /// Delete repositorio Usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteUsuarioAsync(int id)
        {
            try
            {
                var entity = new Usuario()
                {
                    UsuarioId = id
                };
                _context.Usuario.Attach(entity);
                _context.Usuario.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Get All repositorio Usuario

        /// <summary>
        /// Get All repositorio Usuario
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<UsuarioDto>> GetAll()
        {
            try
            {
                var _usuario = await _context.Usuario.Select(u => new UsuarioDto()
                {              
                    UsuariosId = u.UsuarioId,
                    Nombre = u.Nombre,
                    Clave = u.Clave,
                    Tipo = u.Tipo
                }).ToListAsync();
                return _usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Get Id repositorio Usuario
        /// <summary>
        /// Get Id repositorio Usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<UsuarioDto> GetUsuarioById(int id)
        {
            try
            {
                var usuario = await _context.Usuario.Select(u => new UsuarioDto()
                {                    
                    UsuariosId = u.UsuarioId,
                    Nombre = u.Nombre,
                    Clave = u.Clave,
                    Tipo = u.Tipo
                }).FirstOrDefaultAsync(u => u.UsuariosId == id);
                return usuario;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Update repositorio Usuario

        /// <summary>
        /// Update repositorio Usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public async Task<bool> UpdateUsuarioAsync(UsuarioDto usuario)
        {
            try
            {
                var entidad = await _context.Usuario.FirstOrDefaultAsync(e => e.UsuarioId == usuario.UsuariosId);
                entidad.Nombre = usuario.Nombre;
                entidad.Clave = usuario.Clave;
                entidad.Tipo = usuario.Tipo;

                _context.Entry(entidad).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        #endregion
    }
}
