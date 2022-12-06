using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mundial.DAL.Entities
{
    public partial class Resultado
    {
        public int ResultadoId { get; set; }
        public string GolesaFavor { get; set; }
        public string GolesenContra { get; set; }
        public int? NumeroPartido { get; set; }
        public int? EquipoId { get; set; }

        public virtual Equipo Equipo { get; set; }
    }
}
