using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class EntityBase
    {
        public bool Activo { get; set; }
        public int UsuarioCrea { get; set; }
        public int UsuarioModifica { get; set; }
        public DateTime FechaCrea { get; set; }
        public DateTime FechaModifica { get; set; }
    }
}
