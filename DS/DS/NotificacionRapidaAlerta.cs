using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS
{
    public partial class NotificacionRapidaAlerta : UserControl
    {
        public NotificacionRapidaAlerta()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Stop();

            this.Visible = false;

        }

        public void mostrarNotificacion(string notificacion)
        {
            notificacionRapidaLabel.Text = notificacion;

            this.Visible = true;
            this.timer1.Start();
            Application.DoEvents();

        }
    }
}
