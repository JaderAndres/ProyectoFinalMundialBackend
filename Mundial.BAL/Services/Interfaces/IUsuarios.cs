using Mundial.DAL.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mundial.BAL.Services.Interfaces
{
    public interface IUsuarios
    {
        //USUARIOS

        Task<IEnumerable<UsuarioDto>> GetAll();
        Task<UsuarioDto> GetUsuarioById(int id);
        Task<UsuarioDto> CreateUsuarioAsync(UsuarioDto usuario);
        Task<bool> UpdateUsuarioAsync(UsuarioDto usuario);
        Task<bool> DeleteUsuarioAsync(int id);
    }
}
