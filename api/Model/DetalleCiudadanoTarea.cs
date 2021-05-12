using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class DetalleCiudadanoTarea : General
    {
        [Required]
        public DateTime Dia { get; set; }
        public string Detalle { get; set; }
        [ForeignKey("Tarea")]
        public int TareaId { get; set; }
        [ForeignKey("Ciudadano")]
        public int CiudadanoId { get; set; }
        public Ciudadano Ciudadano { get; set; }
        public Tarea Tarea { get; set; }
    }
}
