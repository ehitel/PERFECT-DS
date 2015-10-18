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
using DS.Logica.Seguridad;

namespace DS
{



    public partial class MainWindow : Form
    {
        private enum EstadoPanelError
        {
            Abierto = 0,
            Cerrado = 1

        }

        string CODIGO_USUARIO = "EHITEL";
        string CODIGO_MODULO = "DS";

        public MainWindow()
        {
            InitializeComponent();

            configurarMenuLateral(string.Empty);

            showErrorPanel(EstadoPanelError.Cerrado);

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            cambiarColorFondo();

            Dashboard db = new Dashboard();
            db.MdiParent = this;
            db.Show();
        }


        private void cambiarColorFondo()
        {
            MdiClient ctlMDI;

            foreach (Control ctl in this.Controls)
            {
                try
                {

                    ctlMDI = (MdiClient)ctl;

                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }

        private void disableButton_Click(object sender, EventArgs e)
        {

        }

        void deshabilitarMenuLateral()
        {
            menuLateralPanel.Visible = false;
            menuLateralSplitter.Visible = false;
            menuLateralEnableButton.Visible = true;

        }

        void habilitarMenuLateral()
        {
            menuLateralPanel.Visible = true;
            menuLateralSplitter.Visible = true;
            menuLateralEnableButton.Visible = false;

        }

        private void menuLateralDisableButton_Click(object sender, EventArgs e)
        {
            deshabilitarMenuLateral();
        }

        private void menuLateralEnableButton_Click(object sender, EventArgs e)
        {
            habilitarMenuLateral();
        }


        void configurarMenuLateral(string DESCRIPCION)
        {

            menuLateralBar.Groups.Clear();

            List<PERMISO_USUARIO_MODULO> permisos =
                new Permisos().obetenerPermisoUsuarioModulo(CODIGO_USUARIO, CODIGO_MODULO,
                menuLateralFiltroTextBox.Text.Trim());


            var grupos = permisos.Select(p => new { CODIGO_CATEGORIA = p.CODIGO_CATEGORIA, NOMBRE_CATEGORIA = p.NOMBRE_CATEGORIA }).Distinct();

            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup menuGrupo;

            foreach (var grupo in grupos)
            {
                menuGrupo = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
                menuGrupo.Text = grupo.CODIGO_CATEGORIA;
                menuGrupo.Key = grupo.NOMBRE_CATEGORIA;

                var opciones = permisos.Where(p => p.CODIGO_CATEGORIA == grupo.CODIGO_CATEGORIA).Select(p => p);

                Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem menuOpcion;

                foreach (var opcion in opciones)
                {
                    menuOpcion = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
                    menuOpcion.Text = opcion.NOMBRE_PROGRAMA;
                    menuOpcion.Key = opcion.CODIGO_PROGRAMA;
                    menuOpcion.Tag = opcion.NOMBRE_FORMULARIO;

                    menuOpcion.Settings.AppearancesLarge.Appearance.Image = Image.FromFile(Application.StartupPath + @"\Recursos\Forms\" + opcion.NOMBRE_IMAGEN);
                    menuOpcion.Settings.AppearancesSmall.Appearance.Image = Image.FromFile(Application.StartupPath + @"\Recursos\Forms\" + opcion.NOMBRE_IMAGEN);

                    menuGrupo.Items.Add(menuOpcion);

                }


                menuLateralBar.Groups.Add(menuGrupo);
            }

            if (DESCRIPCION.Trim() == string.Empty)
                menuLateralBar.Groups.CollapseAll();
            else
                menuLateralBar.Groups.ExpandAll();




        }


        private void menuLateralBar_ActiveItemChanged(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
        {
            try
            {
                e.Item.Group.Active = true;

                var form = (Form)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance("DS." + e.Item.Tag.ToString());

                ((IWindow)form).ErrorGenerado += MainWindow_ErrorGenerado;
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex)
            {

                MostrarError("Error en selección de menú", ex.Message, "Menú principal", ex.StackTrace,
                    "Es probable que el programa invocado no exista, favor solicitar ayuda a soporte técnico.", ex);

            }


        }

        void MainWindow_ErrorGenerado(object sender, ErrorEstructura e)
        {
            MostrarError(e);

        }

        private void MostrarError(string titulo, String mensaje, string seccion, string trazo, string comentario, Exception ex)
        {

            ErrorGestor err = new ErrorGestor();

            webBrowser1.DocumentText = err.obtenerError(titulo, seccion, comentario, ex.Message, ex.StackTrace);

            showErrorPanel(EstadoPanelError.Abierto);
        }


        private void MostrarError(ErrorEstructura error)
        {

            if (error.Tipo == TipoError.Error)
            {

                ErrorGestor err = new ErrorGestor();

                webBrowser1.DocumentText = err.obtenerError(error.Titulo, error.Seccion, error.Comentario, error.Mensaje, error.Trazo);

                showErrorPanel(EstadoPanelError.Abierto);
            }
            else if (error.Tipo == TipoError.Confirmacion)
            {
                notificacionRapidaAlerta1.mostrarNotificacion(error.Mensaje);
            }

        }

        private void menuLateralBar_GroupExpanded(object sender, Infragistics.Win.UltraWinExplorerBar.GroupEventArgs e)
        {
            e.Group.Active = true;
        }

        private void menuLateralFiltroTextBox_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            if (e.Button.Key.ToLower() == "limpiar")
            {
                menuLateralFiltroTextBox.Text = string.Empty;

            }

            configurarMenuLateral(menuLateralFiltroTextBox.Text);
        }

        void showErrorPanel(EstadoPanelError Estado)
        {
            switch (Estado)
            {
                case EstadoPanelError.Abierto:
                    panelError.Visible = true;
                    errorSplitter.Visible = true;
                    break;
                case EstadoPanelError.Cerrado:
                    panelError.Visible = false;
                    errorSplitter.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void errorPanelCerrarPicture_Click(object sender, EventArgs e)
        {
            showErrorPanel(EstadoPanelError.Cerrado);
        }

        private void extrarMensajeButton_Click(object sender, EventArgs e)
        {
            ErrorMostrar errorVentana = new ErrorMostrar(webBrowser1.DocumentText);
            errorVentana.WindowState = FormWindowState.Maximized;
            errorVentana.Show(this);
        }



    }
}
