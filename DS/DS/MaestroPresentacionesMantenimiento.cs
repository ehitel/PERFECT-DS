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
    public partial class MaestroPresentacionesMantenimiento : Form, IWindow, IMantenimiento
    {
        public event Delegados.ErrorGenerado ErrorGenerado;
        public event Delegados.RegistroModificado RegistroModificado;


        ValidacionCampos validacion;

        public MaestroPresentacionesMantenimiento(string codigoPresentacion)
        {
            InitializeComponent();

            validacion = new ValidacionCampos();

            validacion.agregarValidacion(codigoPresentacionTextBox, TipoCampos.Texto, string.Empty);
            validacion.agregarValidacion(descripcionPresentacionTextBox, TipoCampos.Texto, string.Empty);

            codigoPresentacionTextBox.Text = codigoPresentacion;
            codigoPresentacionTextBox.ReadOnly = true;


            CargarRegistro();
            

        }

        public MaestroPresentacionesMantenimiento()
        {
            InitializeComponent();

            validacion = new ValidacionCampos();

            validacion.agregarValidacion(codigoPresentacionTextBox, TipoCampos.Texto, string.Empty);
            validacion.agregarValidacion(descripcionPresentacionTextBox, TipoCampos.Texto, string.Empty);

        }

        private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            switch (e.Tool.Key)
            {

                case "guardarRegistro":

                    GuardarRegistros();

                    break;
                case "Cerrar":
                    this.Close();

                    break;
                default:
                    break;
            }
        }

        void GuardarRegistros()
        {
            try
            {

                if (!validacion.formValido(this.errorProvider1))
                {
                    return;
                }



                PRESENTACION presentacion = new PRESENTACION();

                presentacion.CODIGO_PRESENTACION = codigoPresentacionTextBox.Text;
                presentacion.NOMBRE_PRESENTACION = descripcionPresentacionTextBox.Text;

                ResultadoTransaccion res = new PresentacionGestor().guardarRegistro(presentacion);


                if (res.Resultado == TipoResultado.Error)
                {
                    ErrorEstructura error = new ErrorEstructura
                    {
                        Tipo = TipoError.Error,
                        Titulo = "Error guardando presentaciones",
                        Seccion = "Guardar registros",
                        Comentario = "Puede tratarse de un problema momentáneo de conexión, por favor volver a intentar",
                        Mensaje = res.Mensaje
                    };

                    MostrarError(error);

                
                }
                else
                {
                    RegistroModificado(this, EventArgs.Empty);
                    ErrorGenerado(this, new ErrorEstructura { Tipo = TipoError.Confirmacion, Mensaje = res.Mensaje });                    
                }


                Limpiar();

                
            }
            catch (Exception ex)
            {
                ErrorEstructura error = new ErrorEstructura
                {
                    Tipo = TipoError.Error,
                    Titulo = "Error guardarn presentación",
                    Seccion = "Gaurdar datos",
                    Comentario = "Puede tratarse de un problema momentáneo de conexión, por favor volver a intentar",
                    Mensaje = ex.Message,
                    Trazo = ex.StackTrace
                };

            }
        }


        void Limpiar()
        {
            codigoPresentacionTextBox.ReadOnly = false;
            codigoPresentacionTextBox.Clear();
            descripcionPresentacionTextBox.Clear();
            codigoPresentacionTextBox.Focus();
        }


        void CargarRegistro()
        {
            try
            {
                PRESENTACION_CONSULTA presentacion = new PresentacionGestor().obterPresentacion(codigoPresentacionTextBox.Text);


                descripcionPresentacionTextBox.Text = presentacion.NOMBRE_PRESENTACION;

                descripcionPresentacionTextBox.Focus();


            }
            catch (Exception ex)
            {
                ErrorEstructura error = new ErrorEstructura
                {
                    Tipo = TipoError.Error,
                    Titulo = "Error cargando presentación",
                    Seccion = "Cargar presentación",
                    Comentario = "Puede tratarse de un problema momentáneo de conexión, por favor volver a intentar",
                    Mensaje = ex.Message,
                    Trazo = ex.StackTrace
                };
            }
        }

        void MostrarError(ErrorEstructura error)
        {                       
            ErrorGenerado(this, error);
        }

        

    }
}
