﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto2023.views;
using projeto2023.views.frms;
using projeto2023.views.producao;

namespace projeto2023
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btn_cadastros_Click(object sender, EventArgs e)
        {
            frm_cadastros frm = new frm_cadastros();
            frm.ShowDialog();
        }

        private void btn_consultas_Click(object sender, EventArgs e)
        {
            frm_consultas frm = new frm_consultas();
            frm.ShowDialog();
        }

        private void btn_movimentacoes_Click(object sender, EventArgs e)
        {
            frm_movimentacoes frm = new frm_movimentacoes();
            frm.ShowDialog();
        }

        private void btn_relatorios_Click(object sender, EventArgs e)
        {
            frm_relatorios frm = new frm_relatorios();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Frm_logout frm = new Frm_logout();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crud_producao frm = new crud_producao();
            frm.ShowDialog();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
