using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mundial.DAL.Entities
{
    public partial class Jugador
    {
        public Jugador()
        {
            Asistencia = new HashSet<Asistencia>();
            Goleador = new HashSet<Goleador>();
            TarjetaRoja = new HashSet<TarjetaRoja>();
        }

        public int JugadorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public decimal? Estatura { get; set; }
        public int? PosicionId { get; set; }
        public int? EquipoId { get; set; }

        public virtual Equipo Equipo { get; set; }
        public virtual Posicion Posicion { get; set; }
        public virtual ICollection<Asistencia> Asistencia { get; set; }
        public virtual ICollection<Goleador> Goleador { get; set; }
        public virtual ICollection<TarjetaRoja> TarjetaRoja { get; set; }
    }
}
