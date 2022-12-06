using System;
using System.Collections.Generic;

namespace Mundial.DAL.Entities.DTOs
{
    public class ResultadoDto
    {
        public string? NombreEquipo { get; set; }
        public string GolesaFavor { get; set; }
        public string GolesenContra { get; set; }
        public int? NumeroPartido { get; set; }
    }
}
