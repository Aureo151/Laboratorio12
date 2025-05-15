using Laboratorio12.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio12.Models
{
    public class Alimentos : Producto
    {
        [Required]
        public DateTime Fecha_Vencimiento { get; set; }
        [Required]
        public string Unidad_Medida { get; set; }
    }
}
