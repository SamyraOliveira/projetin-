﻿namespace projeto2023.views.frms
{
    partial class frm_movimentacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_movimentacoes));
            this.pnl_movimentacoes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Materiais = new System.Windows.Forms.Button();
            this.btn_Fornecedores = new System.Windows.Forms.Button();
            this.btn_Pedidos = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_colabores = new System.Windows.Forms.Button();
            this.pctb_cadastros = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_movimentacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_cadastros)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_movimentacoes
            // 
            this.pnl_movimentacoes.Controls.Add(this.label2);
            this.pnl_movimentacoes.Location = new System.Drawing.Point(30, 71);
            this.pnl_movimentacoes.Name = "pnl_movimentacoes";
            this.pnl_movimentacoes.Size = new System.Drawing.Size(955, 623);
            this.pnl_movimentacoes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 68);
            this.label1.TabIndex = 19;
            this.label1.Text = "Movimentações";
            // 
            // btn_Materiais
            // 
            this.btn_Materiais.Image = global::projeto2023.Properties.Resources.menu_btnEstoque;
            this.btn_Materiais.Location = new System.Drawing.Point(684, 229);
            this.btn_Materiais.Name = "btn_Materiais";
            this.btn_Materiais.Size = new System.Drawing.Size(210, 136);
            this.btn_Materiais.TabIndex = 18;
            this.btn_Materiais.Text = "MATERIAIS";
            this.btn_Materiais.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Materiais.UseVisualStyleBackColor = true;
            this.btn_Materiais.Click += new System.EventHandler(this.btn_Materiais_Click);
            // 
            // btn_Fornecedores
            // 
            this.btn_Fornecedores.Image = global::projeto2023.Properties.Resources.menu_btnFornecedor;
            this.btn_Fornecedores.Location = new System.Drawing.Point(374, 229);
            this.btn_Fornecedores.Name = "btn_Fornecedores";
            this.btn_Fornecedores.Size = new System.Drawing.Size(211, 136);
            this.btn_Fornecedores.TabIndex = 17;
            this.btn_Fornecedores.Text = "FORNECEDORES";
            this.btn_Fornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Fornecedores.UseVisualStyleBackColor = true;
            this.btn_Fornecedores.Click += new System.EventHandler(this.btn_Fornecedores_Click);
            // 
            // btn_Pedidos
            // 
            this.btn_Pedidos.Image = global::projeto2023.Properties.Resources.menu_btnListaProntos;
            this.btn_Pedidos.Location = new System.Drawing.Point(374, 431);
            this.btn_Pedidos.Name = "btn_Pedidos";
            this.btn_Pedidos.Size = new System.Drawing.Size(211, 136);
            this.btn_Pedidos.TabIndex = 16;
            this.btn_Pedidos.Text = "PEDIDOS";
            this.btn_Pedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Pedidos.UseVisualStyleBackColor = true;
            this.btn_Pedidos.Click += new System.EventHandler(this.btn_Pedidos_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Image = global::projeto2023.Properties.Resources.menu_btnCliente;
            this.btn_Clientes.Location = new System.Drawing.Point(35, 431);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(210, 136);
            this.btn_Clientes.TabIndex = 15;
            this.btn_Clientes.Text = "CLIENTES";
            this.btn_Clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_colabores
            // 
            this.btn_colabores.Image = global::projeto2023.Properties.Resources.menu_btnCliente;
            this.btn_colabores.Location = new System.Drawing.Point(35, 229);
            this.btn_colabores.Name = "btn_colabores";
            this.btn_colabores.Size = new System.Drawing.Size(210, 136);
            this.btn_colabores.TabIndex = 14;
            this.btn_colabores.Text = "COLABORADORES";
            this.btn_colabores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_colabores.UseVisualStyleBackColor = true;
            this.btn_colabores.Click += new System.EventHandler(this.btn_colabores_Click);
            // 
            // pctb_cadastros
            // 
            this.pctb_cadastros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctb_cadastros.Image = global::projeto2023.Properties.Resources.logo;
            this.pctb_cadastros.Location = new System.Drawing.Point(1005, 279);
            this.pctb_cadastros.Name = "pctb_cadastros";
            this.pctb_cadastros.Size = new System.Drawing.Size(292, 309);
            this.pctb_cadastros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb_cadastros.TabIndex = 13;
            this.pctb_cadastros.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "VOLTAR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frm_movimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Materiais);
            this.Controls.Add(this.btn_Fornecedores);
            this.Controls.Add(this.btn_Pedidos);
            this.Controls.Add(this.btn_Clientes);
            this.Controls.Add(this.btn_colabores);
            this.Controls.Add(this.pctb_cadastros);
            this.Controls.Add(this.pnl_movimentacoes);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_movimentacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentações Gerasi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_movimentacoes.ResumeLayout(false);
            this.pnl_movimentacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_cadastros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_movimentacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Materiais;
        private System.Windows.Forms.Button btn_Fornecedores;
        private System.Windows.Forms.Button btn_Pedidos;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_colabores;
        private System.Windows.Forms.PictureBox pctb_cadastros;
        private System.Windows.Forms.Label label2;
    }
}