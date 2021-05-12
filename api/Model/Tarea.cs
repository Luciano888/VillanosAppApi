using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Tarea : General
    {
        [Required(ErrorMessage = "Detalle de la tarea es requerido")]
        public string DetalleTarea { get; set; }
    }
}
