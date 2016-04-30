﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Emision
    {
        [Required]
        public string ID { get; set; }

        [Required]
        [DisplayName("Identificación")]
        public string Identificacion { get; set; }

        [DisplayName("Tipo de identificación")]
        public TipoDeIdentificacion TipoDeIdentificacion { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [DisplayName("Primer apellido")]
        public string PrimerApellido { get; set; }

        [Required]
        [DisplayName("Segundo apellido")]
        public string SegundoApellido { get; set; }
    }
}