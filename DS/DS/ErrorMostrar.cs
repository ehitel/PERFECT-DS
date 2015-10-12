using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS
{
    public partial class ErrorMostrar : Form
    {
        public ErrorMostrar()
        {
            InitializeComponent();
        }

        public ErrorMostrar(string Mensaje)
        {
            InitializeComponent();

            webBrowser1.DocumentText = Mensaje;
        }
    }
}
