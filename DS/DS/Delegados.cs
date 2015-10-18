using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class Delegados
    {

        public delegate void ErrorGenerado(object sender, ErrorEstructura e);

        public delegate void RegistroModificado(object sender, EventArgs e);

    }
}
