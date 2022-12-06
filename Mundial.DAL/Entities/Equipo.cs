using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mundial.DAL.Entities
{
    public partial class Equipo
    {
        public Equipo()
        {
            Jugador = new HashSet<Jugador>();
            Resultado = new HashSet<Resultado>();
            TablaPosicion = new HashSet<TablaPosicion>();
        }

        public int EquipoId { get; set; }
        public string Nombre { get; set; }
        public int? Participaciones { get; set; }

        public virtual ICollection<Jugador> Jugador { get; set; }
        public virtual ICollection<Resultado> Resultado { get; set; }
        public virtual ICollection<TablaPosicion> TablaPosicion { get; set; }
    }
}
