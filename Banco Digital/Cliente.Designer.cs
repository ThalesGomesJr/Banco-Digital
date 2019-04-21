namespace Banco_Digital
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.btsair = new System.Windows.Forms.Button();
            this.btdeposito = new System.Windows.Forms.Button();
            this.btsaque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btsair
            // 
            this.btsair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btsair.Image = global::Banco_Digital.Properties.Resources.cofrinho_com_moeda_de_dolar_dentro_elemento_de_sinal_de_neon_anuncio_brilhante_da_noite_1262_13564;
            this.btsair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btsair.Location = new System.Drawing.Point(79, 334);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(174, 33);
            this.btsair.TabIndex = 2;
            this.btsair.Text = "Sair de Cliente";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // btdeposito
            // 
            this.btdeposito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btdeposito.Image = global::Banco_Digital.Properties.Resources.cofrinho_com_moeda_de_dolar_dentro_elemento_de_sinal_de_neon_anuncio_brilhante_da_noite_1262_13564;
            this.btdeposito.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btdeposito.Location = new System.Drawing.Point(79, 287);
            this.btdeposito.Name = "btdeposito";
            this.btdeposito.Size = new System.Drawing.Size(174, 33);
            this.btdeposito.TabIndex = 1;
            this.btdeposito.Text = "Deposito";
            this.btdeposito.UseVisualStyleBackColor = true;
            this.btdeposito.Click += new System.EventHandler(this.btdeposito_Click);
            // 
            // btsaque
            // 
            this.btsaque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btsaque.Image = global::Banco_Digital.Properties.Resources.cofrinho_com_moeda_de_dolar_dentro_elemento_de_sinal_de_neon_anuncio_brilhante_da_noite_1262_13564;
            this.btsaque.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btsaque.Location = new System.Drawing.Point(79, 240);
            this.btsaque.Name = "btsaque";
            this.btsaque.Size = new System.Drawing.Size(174, 33);
            this.btsaque.TabIndex = 0;
            this.btsaque.Text = "Saque";
            this.btsaque.UseVisualStyleBackColor = true;
            this.btsaque.Click += new System.EventHandler(this.btsaque_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(119, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banco_Digital.Properties.Resources.cofrinho_com_moeda_de_dolar_dentro_elemento_de_sinal_de_neon_anuncio_brilhante_da_noite_1262_13564;
            this.ClientSize = new System.Drawing.Size(332, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btdeposito);
            this.Controls.Add(this.btsaque);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btdeposito;
        private System.Windows.Forms.Button btsaque;
        private System.Windows.Forms.Label label1;
    }
}