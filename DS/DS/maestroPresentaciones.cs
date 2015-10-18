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

                ErrorEstructura error = new ErrorEstructura
                {
                    Titulo = "Error cargando presentaciones",
                    Seccion = "Cargar datos",
                    Comentario = "Puede tratarse de un problema momentáneo de conexión, por favor volver a intentar",
                    Mensaje = ex.Message,
                    Trazo = ex.StackTrace
                };

                mantenimiento_ErrorGenerado(this, error);

            }
        }

        private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            switch (e.Tool.Key)
            {
                case "agregarRegistro":

                    MaestroPresentacionesMantenimiento mantenimiento = new MaestroPresentacionesMantenimiento();
                    mantenimiento.RegistroModificado += mantenimiento_RegistroModificado;
                    mantenimiento.ErrorGenerado += mantenimiento_ErrorGenerado;
                    mantenimiento.MdiParent = this.MdiParent;
                    mantenimiento.Show();

                    break;

                case "Cerrar":
                    this.Close();
                   
                    break;

                default:
                    break;
            }
        }

        void mantenimiento_ErrorGenerado(object sender, ErrorEstructura e)
        {
            ErrorGenerado(this, e);
        }

        void mantenimiento_RegistroModificado(object sender, EventArgs e)
        {
            cargarDatos();
        }


    }
}
