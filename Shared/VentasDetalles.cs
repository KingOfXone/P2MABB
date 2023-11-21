using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2MABB.Shared
{
    public class VentasDetalles
    {
        [Key]
        public int ventasDetailId { get; set; }
        [ForeignKey("VentaId")]
        public int VentaId { get; set; }
        public int cobrado { get; set; }

    }
}
