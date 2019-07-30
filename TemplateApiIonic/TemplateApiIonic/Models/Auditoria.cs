using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateApiIonic.Models
{
    public class Auditoria
    {
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(256, ErrorMessage = "La longitud máxima del campo es 256 caracteres")]
        public string UsuarioCreacion { get; set; }
        
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(256, ErrorMessage = "La longitud máxima del campo es 256 caracteres")]
        public string UsuarioActualizacion { get; set; }
        
        public DateTime FechaActualizacion { get; set; }
    }
}
