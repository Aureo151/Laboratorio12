using Laboratorio12.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio12.Models
{
    public class Electronicos : Producto
    {
        [Required]
        public int Tiempo_Garantia { get; set; }
        [Required]
        public int Voltaje { get; set; }
    }
}