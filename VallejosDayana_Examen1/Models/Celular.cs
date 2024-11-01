﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VallejosDayana_Examen1.Models
{
    public class Celular
    {
        [Key]
        public int IdCelular { get; set; }

        [Required]
        [MaxLength(100)]
        public string Modelo { get; set; }

        public int Año { get; set; }

        [Range(300, 1000)]
        public double Precio { get; set; }

        
        [ForeignKey("DVallejos")]
        public int IdUsuario { get; set; }

        public DVallejos? DVallejos { get; set; }
    }
}
