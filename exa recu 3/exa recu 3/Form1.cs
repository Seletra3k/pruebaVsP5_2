﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exa_recu_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compro_Click(object sender, EventArgs e)
        {
            if (usu.Text.Equals(contra.Text))
            {
                this.Close();
            }
        }
    }
}
