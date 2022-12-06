using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mundial.DAL.Entities
{
    public partial class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Tipo { get; set; }
    }
}
