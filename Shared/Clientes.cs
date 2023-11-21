using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2MABB.Shared
{
    
        public class Clientes
        {
            [Key]
            public int ClienteId { get; set; }
            [Required(ErrorMessage = "Debe ingresar el nombre")]
            [MinLength(2, ErrorMessage = "El nombre debe tener al menos 2 caracteres")]
            [RegularExpression(@"^[a-zA-ZáéíóúüÁÉÍÓÚÜ\s]+$", ErrorMessage = "Solo se permiten letras y espacios")]
             public string? Nombres { get; set; }
    }
}
