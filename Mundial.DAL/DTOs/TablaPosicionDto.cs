using System;
using System.Collections.Generic;

namespace Mundial.DAL.Entities.Dtos
{
    public class TablaPosicionDto
    {
        public string? NombreEquipo { get; set; }
        public int? Pj { get; set; }
        public int? Pe { get; set; }
        public int? Pp { get; set; }
        public int? Gf { get; set; }
        public int? Gc { get; set; }
        public int? Puntos { get; set; }

    }
}
