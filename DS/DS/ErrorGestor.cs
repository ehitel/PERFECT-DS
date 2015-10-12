using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.IO;

namespace DS
{
    public class ErrorGestor
    {
        public string obtenerError(string titulo, string seccion, string comentario, String mensaje, string trazo)
        {
            StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("<html>");
            sb.AppendLine("<header>");

            sb.AppendLine("</header>");
            sb.AppendLine("<body>");
            sb.AppendFormat("<h1>{0}</h1>", titulo);
            sb.AppendFormat("<h2>{0}</h2>", seccion);
            sb.AppendFormat("<p><b>{0}</b></p>", comentario);
            sb.AppendFormat("<p>{0}</p>", mensaje);
            sb.AppendFormat("<p><i>{0}</i></p>", trazo);
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");


            return sb.ToString();

        }
    }
}
