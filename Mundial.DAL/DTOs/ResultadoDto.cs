using System;
using System.Collections.Generic;

namespace Mundial.DAL.Entities.DTOs
{
    public class ResultadoDto
    {
        public int ResultadoId { get; set; }        
        public string GolesaFavor { get; set; }
        public string GolesenContra { get; set; }
        public int? NumeroPartido { get; set; }
        public int? EquipoId { get; set; }
        public string? NombreEquipo { get; set; }        
}
}
