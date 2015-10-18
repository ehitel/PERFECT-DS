using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    interface IMantenimiento
    {
        event Delegados.RegistroModificado RegistroModificado;
    }
}
