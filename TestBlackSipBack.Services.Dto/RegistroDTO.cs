using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestBlackSipBack.Services.Dto
{
    public partial class RegistroDTO
    {
        [Required(ErrorMessage = "El ID es requerido.")]
        public long Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        [MinLength(6)]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El email es requerido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "No se reconoce como numero telefonico.")]
        [DataType(DataType.PhoneNumber)]
        public long? Telefono { get; set; }
        public bool? Procesado { get; set; }
    }
}
