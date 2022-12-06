using System;
using System.Collections.Generic;

namespace Mundial.DAL.Entities.DTOs
{
    public class UsuarioDto
    {
        public int UsuariosId { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Tipo { get; set; }
    }
}
