﻿using Projecto_LDS.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_LDS
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Electricidade_Click(object sender, EventArgs e)
        {
            MenuElect menuElect = new MenuElect();
            this.Hide();
            menuElect.ShowDialog();
            this.Close();

        }

        private void GN_Click(object sender, EventArgs e)
        {

            this.Hide();
            new MenuGas().ShowDialog();
            ShowDialog();
            /*MenuGas menuGas= new MenuGas();
            this.Hide();
            menuGas.ShowDialog();
            this.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configuracoes configur = new Configuracoes();
            this.Hide();
            configur.ShowDialog();
            this.Close();
        }
    }
}