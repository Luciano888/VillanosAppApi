using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Ciudadano : General
    {
        [Required(ErrorMessage = "Nombre es requerido")]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Apellido es requerido")]
        [StringLength(30)]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Identificación es requerido")]
        [StringLength(15)]
        public string Identificacion { get; set; }
        [Required(ErrorMessage = "Genero es requerido")]
        public bool Genero { get; set; }
        [Required(ErrorMessage = "Domicilio es requerido")]
        public string Domicilio { get; set; }
    }
}
