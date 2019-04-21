namespace Banco_Digital
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btadmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btcliente = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btadmin
            // 
            this.btadmin.Location = new System.Drawing.Point(118, 161);
            this.btadmin.Name = "btadmin";
            this.btadmin.Size = new System.Drawing.Size(174, 33);
            this.btadmin.TabIndex = 0;
            this.btadmin.Text = "Acesso Administrativo";
            this.btadmin.UseVisualStyleBackColor = true;
            this.btadmin.Click += new System.EventHandler(this.btadmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(122, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Banco Digital";
            // 
            // btcliente
            // 
            this.btcliente.Location = new System.Drawing.Point(118, 224);
            this.btcliente.Name = "btcliente";
            this.btcliente.Size = new System.Drawing.Size(174, 33);
            this.btcliente.TabIndex = 1;
            this.btcliente.Text = "Acesso Cliente";
            this.btcliente.UseVisualStyleBackColor = true;
            this.btcliente.Click += new System.EventHandler(this.btcliente_Click);
            // 
            // btsair
            // 
            this.btsair.Location = new System.Drawing.Point(118, 287);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(174, 33);
            this.btsair.TabIndex = 2;
            this.btsair.Text = "Sair do Sistema";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "v1.0.0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(411, 373);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btcliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btadmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Digital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btadmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btcliente;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Label label2;
    }
}

