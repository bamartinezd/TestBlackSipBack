using System;
using System.Collections.Generic;

namespace TestBlackSipBack.Domain.Entities
{
    public partial class Registro
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public long? Telefono { get; set; }
        public bool? Procesado { get; set; }
    }
}
