﻿namespace Banco_Digital
{
    partial class Saque
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
            this.btdeposito = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbvalor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnum_conta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbsenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btdeposito
            // 
            this.btdeposito.Location = new System.Drawing.Point(230, 194);
            this.btdeposito.Name = "btdeposito";
            this.btdeposito.Size = new System.Drawing.Size(82, 27);
            this.btdeposito.TabIndex = 3;
            this.btdeposito.Text = "Saque";
            this.btdeposito.UseVisualStyleBackColor = true;
            this.btdeposito.Click += new System.EventHandler(this.btsaque_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(125, 194);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(77, 27);
            this.btcancelar.TabIndex = 4;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor:";
            // 
            // tbvalor
            // 
            this.tbvalor.Location = new System.Drawing.Point(125, 93);
            this.tbvalor.MaxLength = 100;
            this.tbvalor.Name = "tbvalor";
            this.tbvalor.Size = new System.Drawing.Size(187, 20);
            this.tbvalor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero da Conta:";
            // 
            // tbnum_conta
            // 
            this.tbnum_conta.Location = new System.Drawing.Point(125, 48);
            this.tbnum_conta.MaxLength = 100;
            this.tbnum_conta.Name = "tbnum_conta";
            this.tbnum_conta.Size = new System.Drawing.Size(187, 20);
            this.tbnum_conta.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha:";
            // 
            // tbsenha
            // 
            this.tbsenha.Location = new System.Drawing.Point(125, 134);
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.PasswordChar = '*';
            this.tbsenha.Size = new System.Drawing.Size(187, 20);
            this.tbsenha.TabIndex = 2;
            // 
            // Saque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 269);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbsenha);
            this.Controls.Add(this.btdeposito);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbvalor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbnum_conta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Saque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btdeposito;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbvalor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnum_conta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbsenha;
    }
}