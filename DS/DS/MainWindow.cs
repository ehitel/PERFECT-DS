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

        string CODIGO_USUARIO = "EHITEL";
        string CODIGO_MODULO = "DS";

        public MainWindow()
        {
            InitializeComponent();

            configurarMenuLateral(string.Empty);

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
            e.Item.Group.Active = true;
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



    }
}
