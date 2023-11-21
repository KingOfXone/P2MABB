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
            public required string Nombres { get; set; }
        }
    
}
