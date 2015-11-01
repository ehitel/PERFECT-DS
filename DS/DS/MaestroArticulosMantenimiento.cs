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

            cargarPresentaciones();
            cargarCategorias();



            CargarRegistro();

            codigoArticuloTextBox.TextChanged += codigoArticuloTextBox_TextChanged;


        }


        public MaestroArticulosMantenimiento()
        {

            InitializeComponent();

            validacion = new ValidacionCampos();

            validacion.agregarValidacion(codigoArticuloTextBox, TipoCampos.Texto, string.Empty);
            validacion.agregarValidacion(nombreLargoTextBox, TipoCampos.Texto, string.Empty);


            codigoArticuloTextBox.TextChanged += codigoArticuloTextBox_TextChanged;

            cargarPresentaciones();
            cargarCategorias();



        }


        void codigoArticuloTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ARTICULO_CONSULTA articulo = new ArticuloGestor().obtenerArticulo(codigoArticuloTextBox.Text);

                limpiarRegistros();

                if (articulo == null)
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

        private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            switch (e.Tool.Key)
            {
                case "Nuevo":    // ButtonTool
                    codigoArticuloTextBox.Clear();
                    codigoArticuloTextBox.ReadOnly = false;

                    limpiarRegistros();

                    codigoArticuloTextBox.Focus();

                    break;

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



                ARTICULO articulo = new ARTICULO();

                articulo.CODIGO_ARTICULO = codigoArticuloTextBox.Text;
                articulo.NOMBRE_ARTICULO = nombreLargoTextBox.Text;
                articulo.NOMBRE_CORTO = nombreCortoTextBox.Text;
                articulo.CODIGO_CATEGORIA = categoriaComboBox.SelectedValue.ToString();
                articulo.DESCRIPCION = descripcionTextBox.Text;
                articulo.CLASIFICACION1 = clasificacion1TextBox.Text;
                articulo.CLASIFICACION2 = clasificacion2TextBox.Text;
                articulo.CLASIFICACION3 = clasificacion3TextBox.Text;
                articulo.CLASIFICACION4 = clasificacion4TextBox.Text;
                articulo.CAMBIAR_DESCRIPCION = cambiarNombreCheckBox.Checked;
                articulo.PRESENTACION_BASE = presentacionBaseComboBox.SelectedValue.ToString();
                articulo.INVENTARIO_MINIMO = Convert.ToInt32(inventarioMinimoTextBox.Value);
                articulo.INVENTARIO_MAXIMO = Convert.ToInt32(inventarioMaximoTextBox.Value);
                articulo.MANEJA_INVENTARIO = manejaInventarioCheckBox.Checked;
                articulo.PERMITE_COMPRA = permiteComprasCheck.Checked;
                articulo.PERMITE_VENTA = permiteVentasCheck.Checked;
                articulo.PAGA_IMPUESTO = pagaImpuestoVentasCheck.Checked;
                articulo.CONSULTAR_PRECIO = solicitarPrecioVentaCheckBox.Checked;
                articulo.PRECIO_VENTA = Convert.ToDecimal(precioVentaEstandarTextBox.Value);
                


                ResultadoTransaccion res = new ArticuloGestor().guardarRegistro(articulo);


                if (res.Resultado == TipoResultado.Error)
                {
                    ErrorEstructura error = new ErrorEstructura
                    {
                        Tipo = TipoError.Error,
                        Titulo = "Error guardando artículo",
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

                limpiarRegistros();

                ARTICULO_CONSULTA articulo = new ArticuloGestor().obtenerArticulo(codigoArticuloTextBox.Text);



                nombreLargoTextBox.Text = articulo.NOMBRE_ARTICULO;                
                nombreCortoTextBox.Text = articulo.NOMBRE_CORTO;

                categoriaComboBox.SelectedValue  = articulo.CODIGO_CATEGORIA;

                descripcionTextBox.Text = articulo.DESCRIPCION;
                clasificacion1TextBox.Text = articulo.CLASIFICACION1;
                clasificacion2TextBox.Text = articulo.CLASIFICACION2;
                clasificacion3TextBox.Text = articulo.CLASIFICACION3;
                clasificacion4TextBox.Text = articulo.CLASIFICACION4;

                cambiarNombreCheckBox.Checked = articulo.CAMBIAR_DESCRIPCION;
                presentacionBaseComboBox.SelectedValue = articulo.PRESENTACION_BASE;
                inventarioMinimoTextBox.Value = articulo.INVENTARIO_MINIMO;
                inventarioMaximoTextBox.Value = articulo.INVENTARIO_MAXIMO;
                manejaInventarioCheckBox.Checked = articulo.MANEJA_INVENTARIO;

                permiteComprasCheck.Checked = articulo.PERMITE_COMPRA;
                permiteVentasCheck.Checked = articulo.PERMITE_VENTA;
                pagaImpuestoVentasCheck.Checked = articulo.PAGA_IMPUESTO;
                solicitarPrecioVentaCheckBox.Checked = articulo.CONSULTAR_PRECIO;

                precioVentaEstandarTextBox.Value = articulo.PRECIO_VENTA;
                               


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
 
        void cargarPresentaciones()
        {

            try
            {

                PresentacionGestor gestor = new PresentacionGestor();

                presentacionBaseComboBox.DisplayMember = "NOMBRE_PRESENTACION";
                presentacionBaseComboBox.ValueMember = "CODIGO_PRESENTACION";
                presentacionBaseComboBox.DataSource = gestor.obtenerCatalogoPresentaciones();

            }
            catch (Exception ex)
            {

                ErrorEstructura error = new ErrorEstructura
                {
                    Tipo = TipoError.Error,
                    Titulo = "Cargando presentaciones",
                    Seccion = "Presentación base del artículo",
                    Comentario = "Favor comunicarse con soporte técnico",
                    Mensaje = ex.Message,
                    Trazo = ex.StackTrace
                };

                MostrarError(error);
            }
        }

        void cargarCategorias()
        {

            try
            {

                ArticuloCategoriaGestor gestor = new ArticuloCategoriaGestor();

                categoriaComboBox.DisplayMember = "NOMBRE_CATEGORIA";
                categoriaComboBox.ValueMember = "CODIGO_CATEGORIA";
                categoriaComboBox.DataSource = gestor.obtenerCatalogo();

            }
            catch (Exception ex)
            {

                ErrorEstructura error = new ErrorEstructura
                {
                    Tipo = TipoError.Error,
                    Titulo = "Cargando presentaciones",
                    Seccion = "Presentación base del artículo",
                    Comentario = "Favor comunicarse con soporte técnico",
                    Mensaje = ex.Message,
                    Trazo = ex.StackTrace
                };

                MostrarError(error);
            }
        }

        void limpiarRegistros()
        {

            nombreLargoTextBox.Clear();
            nombreCortoTextBox.Clear();
            categoriaComboBox.SelectedIndex = -1;
            descripcionTextBox.Clear();
            clasificacion1TextBox.Clear();
            clasificacion2TextBox.Clear();
            clasificacion3TextBox.Clear();
            clasificacion4TextBox.Clear();

            cambiarNombreCheckBox.Checked = false;
            presentacionBaseComboBox.SelectedIndex = -1;
            inventarioMinimoTextBox.Value = 0;
            inventarioMaximoTextBox.Value = 0;
            manejaInventarioCheckBox.Checked = true;

            permiteComprasCheck.Checked = true;
            permiteVentasCheck.Checked = true;
            pagaImpuestoVentasCheck.Checked = true;
            solicitarPrecioVentaCheckBox.Checked = false;

            precioVentaEstandarTextBox.Value = 0;

        }


    }
}
