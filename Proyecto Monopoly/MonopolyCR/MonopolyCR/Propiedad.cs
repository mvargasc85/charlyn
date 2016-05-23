using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyCR
{
    public class Propiedad
    {
        public int IdPropiedad { get; set; }
        public String Nombre { get; set; }
        public Double ValorCompra { get; set; }
        public Double ValorPeaje { get; set; }
        public int IdPropietario { get; set; }

        public String MainPanelId { get; set; }
        public String HeaderPanelId { get; set; }

        public Object MainPanel { get; set; }
        public Object HeaderPanel { get; set; }

    }
}
