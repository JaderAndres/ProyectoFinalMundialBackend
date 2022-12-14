using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mundial.DAL.Entities
{
    public partial class Goleador
    {
        public int GoleadorId { get; set; }
        public int? Goles { get; set; }
        public int? JugadorId { get; set; }

        public virtual Jugador Jugador { get; set; }
    }
}
