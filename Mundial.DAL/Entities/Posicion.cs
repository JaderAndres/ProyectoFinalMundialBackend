using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mundial.DAL.Entities
{
    public partial class Posicion
    {
        public Posicion()
        {
            Jugador = new HashSet<Jugador>();
        }

        public int PosicionId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Jugador> Jugador { get; set; }
    }
}
