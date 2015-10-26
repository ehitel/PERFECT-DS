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
    public partial class MaestroArticulos : Form, IWindow
    {

        public event Delegados.ErrorGenerado ErrorGenerado;

        public MaestroArticulos()
        {
            InitializeComponent();
            cargarDatos();
        }

        void cargarDatos()
        {
            try
            {
                ultraGrid1.SetDataBinding(new ArticuloCategoriaGestor().obtenerCatalogo(), null, true);
                ultraGrid1.DataBind();
            }
            catch (Exception ex)
            {

                ErrorEstructura error = new ErrorEstructura
                {
                    Tipo = TipoError.Error,
                    Titulo = "Error cargando artículos",
                    Seccion = "Cargar artículos",
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

                    MaestroArticulosMantenimiento mantenimiento = new MaestroArticulosMantenimiento();
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

        private void ultraGrid1_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            try
            {

                if (e.Cell.Column.Key.ToLower() == "editar")
                {

                    MaestroCategoriasMantenimiento mantenimiento = new MaestroCategoriasMantenimiento(e.Cell.Row.Cells["CODIGO_CATEGORIA"].Text);
                    mantenimiento.RegistroModificado += mantenimiento_RegistroModificado;
                    mantenimiento.ErrorGenerado += mantenimiento_ErrorGenerado;
                    mantenimiento.MdiParent = this.MdiParent;
                    mantenimiento.Show();
                }

                if (e.Cell.Column.Key.ToLower() == "borrar")
                {
                    borrarRegistro(e.Cell.Row.Cells["CODIGO_CATEGORIA"].Text);
                }

            }
            catch (Exception ex)
            {

                ErrorEstructura error = new ErrorEstructura
                {
                    Tipo = TipoError.Error,
                    Titulo = "Error seleccionadno artículo",
                    Seccion = "Selección de artículo",
                    Comentario = "Puede tratarse de un problema momentáneo de conexión, por favor volver a intentar",
                    Mensaje = ex.Message,
                    Trazo = ex.StackTrace
                };

                mantenimiento_ErrorGenerado(this, error);
            }
        }

        void borrarRegistro(string codigoCategoria)
        {
            try
            {

                if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Atención", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }

                ResultadoTransaccion res = new ArticuloCategoriaGestor().borrarRegistro(codigoCategoria);

                if (res.Resultado == TipoResultado.Error)
                {
                    ErrorEstructura error = new ErrorEstructura
                    {
                        Tipo = TipoError.Error,
                        Titulo = "Error borrando artículo",
                        Seccion = "Borrar artículo",
                        Comentario = "El registor podría estar relacionado con otros registros.",
                        Mensaje = res.Mensaje
                    };

                    ErrorGenerado(this, error);


                }
                else
                {
                    ErrorGenerado(this, new ErrorEstructura { Tipo = TipoError.Confirmacion, Mensaje = res.Mensaje });
                }

                cargarDatos();

            }
            catch (Exception ex)
            {

                ErrorEstructura error = new ErrorEstructura
                {
                    Tipo = TipoError.Error,
                    Titulo = "Error borrando artículo",
                    Seccion = "Borrar artículo",
                    Comentario = "El registor podría estar relacionado con otros registros.",
                    Mensaje = ex.Message,
                    Trazo = ex.StackTrace
                };

                mantenimiento_ErrorGenerado(this, error);

            }
        }


    }
}
