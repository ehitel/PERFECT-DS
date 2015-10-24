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
    public partial class MaestroCategoriasMantenimiento : Form, IWindow, IMantenimiento
    {
        public event Delegados.ErrorGenerado ErrorGenerado;
        public event Delegados.RegistroModificado RegistroModificado;


        ValidacionCampos validacion;

        public MaestroCategoriasMantenimiento(string codigoCategoria)
        {
            InitializeComponent();

            validacion = new ValidacionCampos();

            validacion.agregarValidacion(codigoCategoríaTextBox, TipoCampos.Texto, string.Empty);
            validacion.agregarValidacion(descripcionCategoriaTextBox, TipoCampos.Texto, string.Empty);

            codigoCategoríaTextBox.Text = codigoCategoria;
            codigoCategoríaTextBox.ReadOnly = true;


            CargarRegistro();

            codigoCategoríaTextBox.TextChanged+=codigoCategoríaTextBox_TextChanged;
            

        }

        public MaestroCategoriasMantenimiento()
        {
            InitializeComponent();

            validacion = new ValidacionCampos();

            validacion.agregarValidacion(codigoCategoríaTextBox, TipoCampos.Texto, string.Empty);
            validacion.agregarValidacion(descripcionCategoriaTextBox, TipoCampos.Texto, string.Empty);


            codigoCategoríaTextBox.TextChanged += codigoCategoríaTextBox_TextChanged;

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



                ARTICULO_CATEGORIA categoria = new ARTICULO_CATEGORIA();

                categoria.CODIGO_CATEGORIA = codigoCategoríaTextBox.Text;
                categoria.NOMBRE_CATEGORIA = descripcionCategoriaTextBox.Text;

                ResultadoTransaccion res = new ArticuloCategoriaGestor().guardarRegistro(categoria);


                if (res.Resultado == TipoResultado.Error)
                {
                    ErrorEstructura error = new ErrorEstructura
                    {
                        Tipo = TipoError.Error,
                        Titulo = "Error guardando categoría de artículo",
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
                    Titulo = "Error guardando categoría de artículo",
                    Seccion = "Gaurdar datos",
                    Comentario = "Puede tratarse de un problema momentáneo de conexión, por favor volver a intentar",
                    Mensaje = ex.Message,
                    Trazo = ex.StackTrace
                };

            }
        }


        void Limpiar()
        {
            codigoCategoríaTextBox.ReadOnly = false;
            codigoCategoríaTextBox.Clear();
            descripcionCategoriaTextBox.Clear();
            codigoCategoríaTextBox.Focus();
        }


        void CargarRegistro()
        {
            try
            {
                CATEGORIA_CONSULTA categoria = new ArticuloCategoriaGestor().obterCategoria(codigoCategoríaTextBox.Text);


                descripcionCategoriaTextBox.Text = categoria.NOMBRE_CATEGORIA;

                descripcionCategoriaTextBox.Focus();


            }
            catch (Exception ex)
            {
                ErrorEstructura error = new ErrorEstructura
                {
                    Tipo = TipoError.Error,
                    Titulo = "Error cargando categoría de artículo",
                    Seccion = "Cargar artículo",
                    Comentario = "Puede tratarse de un problema momentáneo de conexión, por favor volver a intentar",
                    Mensaje = ex.Message,
                    Trazo = ex.StackTrace
                };

                MostrarError(error);
            }
        }

        void MostrarError(ErrorEstructura error)
        {                       
            ErrorGenerado(this, error);
        }

        private void codigoCategoríaTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CATEGORIA_CONSULTA categoria = new ArticuloCategoriaGestor().obterCategoria(codigoCategoríaTextBox.Text);

                if (categoria == null)
                {
                    return;
                }
                else
                {
                    CargarRegistro();
                }
            }
            catch (Exception ex)
            {

                ErrorEstructura error = new ErrorEstructura
                {
                    Tipo = TipoError.Error,
                    Titulo = "Error cargando categoría de artículo",
                    Seccion = "Cargar artículo",
                    Comentario = "Puede tratarse de un problema momentáneo de conexión, por favor volver a intentar",
                    Mensaje = ex.Message,
                    Trazo = ex.StackTrace
                };

                MostrarError(error);
            }
        }

        

    }
}
