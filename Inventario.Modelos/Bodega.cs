using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Debe Digitar el nombre")]
        [MaxLength(60,ErrorMessage ="Nombre debe tener maximo 60 caracter")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe Digitar la descripcion")]
        [MaxLength(100, ErrorMessage = "Descripcion debe tener maximo 100 caracter")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Debe poner  el estado")]
   
        public bool Estado { get; set; } 
        
    }
}
