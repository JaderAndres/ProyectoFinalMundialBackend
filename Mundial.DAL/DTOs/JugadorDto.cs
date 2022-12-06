using System;
using System.Collections.Generic;

namespace Mundial.DAL.Entities.DTOs
{
    public class JugadorDto
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public decimal? Estatura { get; set; }
        public string? Posicion { get; set; }
        public string NombreEquipo { get; set; }
    }
}
