using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio12.Models
{
    public class Producto
    {
        [Required]    
        public  string Codigo { get; set; }
        [Required]
        public  string Nombre { get; set; }
        [Required]
        public  string Descripcion { get; set; }
        [Required]
        public   string Tipo { get; set; }
        [Required]
        public  int Precio_Compra {  get; set; }
        [Required]
        public  int Precio_Venta { get; set; }
        
    }
}
