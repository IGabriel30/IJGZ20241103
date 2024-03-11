using System;
using System.Collections.Generic;

namespace IJGZ20241103.Models
{
    public partial class DireccionesProveedor
    {
        public int IdDireccion { get; set; }
        public int ProveedorId { get; set; }
        public string Direccion { get; set; } = null!;
        public string? Ciudad { get; set; }
        public string? Pais { get; set; }

        public virtual Proveedore Proveedor { get; set; } = null!;
    }
}
