﻿using System;
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
    public partial class MaestroPresentaciones : Form
    {

        public event Delegados.ErrorGenerado ErrorGenerado;

        public MaestroPresentaciones()
        {
            InitializeComponent();
        }
    }
}
