using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mundial.DAL.Entities
{
    public partial class TablaPosicion
    {
        public int TablaPosicionId { get; set; }
        public int? Pj { get; set; }
        public int? Pe { get; set; }
        public int? Pp { get; set; }
        public int? Gf { get; set; }
        public int? Gc { get; set; }
        public int? EquipoId { get; set; }

        public virtual Equipo Equipo { get; set; }
    }
}
