using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class ErrorEstructura: EventArgs
    {
        public string Titulo { get; set; }
        public string Seccion { get; set; }
        public string Comentario { get; set; }
        public string Mensaje { get; set; }
        public string Trazo { get; set; }

    }
}
