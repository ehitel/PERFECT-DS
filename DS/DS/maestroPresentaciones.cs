using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DS.Logica;

namespace DS
{
    public partial class MaestroPresentaciones : Form, IWindow
    {

        public event Delegados.ErrorGenerado ErrorGenerado;
       
        public MaestroPresentaciones()
        {
            InitializeComponent();
            cargarDatos();
        }

        void cargarDatos()
        {
            try
            {
                ultraGrid1.SetDataBinding(new PresentacionGestor().obtenerCatalogoPresentaciones(), null, true);
                ultraGrid1.DataBind();
            }
            catch (Exception ex)
            {
                if (ErrorGenerado != null)
                {
                    ErrorGenerado(this, new ErrorEstructura
                    {
                        Titulo = "Error cargando presentaciones",
                        Seccion = "Cargar datos",
                        Comentario = "Puede tratarse de un problema momentáneo de conexión, por favor volver a intentar",
                        Mensaje = ex.Message,
                        Trazo = ex.StackTrace
                    });
                }
            }
        }

       
    }
}
