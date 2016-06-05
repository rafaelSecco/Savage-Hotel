﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savage_Hotel_System.Views
{
    public partial class Quarto_Menu : Form
    {
        private MenuMain Main;

        public Quarto_Menu()
        {
            InitializeComponent();
        }

        public Quarto_Menu(MenuMain MenuMain)
        {
            InitializeComponent();
            this.Main = MenuMain;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form Cadastro = new Quarto_Cadastro(this);
            this.Hide();
            Cadastro.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form Lista = new Quarto_List(this);
            this.Hide();
            Lista.Show();
        }
    }
}
