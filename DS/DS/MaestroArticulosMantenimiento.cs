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
using System.Xml;
namespace DS
{
    public partial class MaestroArticulosMantenimiento : Form, IWindow, IMantenimiento
    {
        public event Delegados.ErrorGenerado ErrorGenerado;
        public event Delegados.RegistroModificado RegistroModificado;


        ValidacionCampos validacion;

        public MaestroArticulosMantenimiento(string codigoCategoria)
        {
            InitializeComponent();

            validacion = new ValidacionCampos();

            validacion.agregarValidacion(codigoArticuloTextBox, TipoCampos.Texto, string.Empty);
            validacion.agregarValidacion(nombreLargoTextBox, TipoCampos.Texto, string.Empty);

            codigoArticuloTextBox.Text = codigoCategoria;
            codigoArticuloTextBox.ReadOnly = true;


            CargarRegistro();

            codigoArticuloTextBox.TextChanged += codigoCategoríaTextBox_TextChanged;


        }

        public MaestroArticulosMantenimiento()
        {
            InitializeComponent();

            validacion = new ValidacionCampos();

            validacion.agregarValidacion(codigoArticuloTextBox, TipoCampos.Texto, string.Empty);
            validacion.agregarValidacion(nombreLargoTextBox, TipoCampos.Texto, string.Empty);


            codigoArticuloTextBox.TextChanged += codigoCategoríaTextBox_TextChanged;

            generarDocumento();

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

                categoria.CODIGO_CATEGORIA = codigoArticuloTextBox.Text;
                categoria.NOMBRE_CATEGORIA = nombreLargoTextBox.Text;

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
            codigoArticuloTextBox.ReadOnly = false;
            codigoArticuloTextBox.Clear();
            nombreLargoTextBox.Clear();
            codigoArticuloTextBox.Focus();
        }


        void CargarRegistro()
        {
            try
            {
                CATEGORIA_CONSULTA categoria = new ArticuloCategoriaGestor().obterCategoria(codigoArticuloTextBox.Text);


                nombreLargoTextBox.Text = categoria.NOMBRE_CATEGORIA;

                nombreLargoTextBox.Focus();


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
                CATEGORIA_CONSULTA categoria = new ArticuloCategoriaGestor().obterCategoria(codigoArticuloTextBox.Text);

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


        string generarDocumento()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(docNode);

                XmlNode articulosNodo = doc.CreateElement("ARTICULOS");
                doc.AppendChild(articulosNodo);

                XmlNode articuloNodo = doc.CreateElement("ARTICULO");
                articulosNodo.AppendChild(articuloNodo);


                XmlNode nodo = doc.CreateElement("CODIGO_ARTICULO");
                nodo.AppendChild(doc.CreateTextNode(""));
                articuloNodo.AppendChild(nodo);


                nodo = doc.CreateElement("NOMBRE_ARTICULO");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);


                nodo = doc.CreateElement("NOMBRE_CORTO");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);

                nodo = doc.CreateElement("DESCRIPCION");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);


                nodo = doc.CreateElement("CODIGO_CATEGORIA");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);


                nodo = doc.CreateElement("CLASIFICACION1");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);


                nodo = doc.CreateElement("CLASIFICACION2");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);


                nodo = doc.CreateElement("CLASIFICACION3");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);

                nodo = doc.CreateElement("CLASIFICACION4");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);


                nodo = doc.CreateElement("PRESENTACION_BASE");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);


                nodo = doc.CreateElement("PERMITE_VENTA");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);

                nodo = doc.CreateElement("PERMITE_COMPRA");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);


                nodo = doc.CreateElement("CAMBIAR_DESCRIPCION");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);


                nodo = doc.CreateElement("CONSULTAR_PRECIO");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);


                nodo = doc.CreateElement("PAGA_IMPUESTO");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);

                nodo = doc.CreateElement("PRECIO_VENTA");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);

                nodo = doc.CreateElement("MANEJA_INVENTARIO");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);

                nodo = doc.CreateElement("INVENTARIO_MINIMO");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);

                nodo = doc.CreateElement("INVENTARIO_MAXIMO");
                nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
                articuloNodo.AppendChild(nodo);



                XmlNode presentacionesNodo = doc.CreateElement("PRESENTACIONES");
                articuloNodo.AppendChild(presentacionesNodo);


                XmlNode presentacionesSubNodo = doc.CreateElement("PRESENTACION");
                presentacionesNodo.AppendChild(presentacionesSubNodo);


                XmlNode presentacionNodo = doc.CreateElement("CODIGO_PRESENTACION");
                presentacionNodo.AppendChild(doc.CreateTextNode("0001"));
                presentacionesSubNodo.AppendChild(presentacionNodo);

                presentacionNodo = doc.CreateElement("FACTOR");
                presentacionNodo.AppendChild(doc.CreateTextNode("1"));
                presentacionesSubNodo.AppendChild(presentacionNodo);

                presentacionesSubNodo = doc.CreateElement("PRESENTACION");
                presentacionesNodo.AppendChild(presentacionesSubNodo);


                presentacionNodo = doc.CreateElement("CODIGO_PRESENTACION");
                presentacionNodo.AppendChild(doc.CreateTextNode("0001"));
                presentacionesSubNodo.AppendChild(presentacionNodo);

                presentacionNodo = doc.CreateElement("FACTOR");
                presentacionNodo.AppendChild(doc.CreateTextNode("1"));
                presentacionesSubNodo.AppendChild(presentacionNodo);


                string xmlDoc = doc.InnerXml.ToString();

                return xmlDoc;


            }
            catch (Exception ex)
            {

                ErrorEstructura error = new ErrorEstructura
                {
                    Tipo = TipoError.Error,
                    Titulo = "Error preaparando transacción de artículo",
                    Seccion = "Preparando transacción artículo",
                    Comentario = "Favor comunicarse con soporte técnico",
                    Mensaje = ex.Message,
                    Trazo = ex.StackTrace
                };

                MostrarError(error);

                return null;
            }
        }



    }
}
