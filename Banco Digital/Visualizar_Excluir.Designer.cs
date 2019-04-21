namespace Banco_Digital
{
    partial class Visualizar_Excluir
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
            this.btapagar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.lista_clientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lista_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btapagar
            // 
            this.btapagar.Location = new System.Drawing.Point(364, 309);
            this.btapagar.Name = "btapagar";
            this.btapagar.Size = new System.Drawing.Size(103, 27);
            this.btapagar.TabIndex = 2;
            this.btapagar.Text = "Apagar Cliente";
            this.btapagar.UseVisualStyleBackColor = true;
            this.btapagar.Click += new System.EventHandler(this.btapagar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(103, 309);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(103, 27);
            this.btcancelar.TabIndex = 3;
            this.btcancelar.Text = "Fechar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // lista_clientes
            // 
            this.lista_clientes.AllowUserToAddRows = false;
            this.lista_clientes.AllowUserToDeleteRows = false;
            this.lista_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_clientes.Location = new System.Drawing.Point(13, 13);
            this.lista_clientes.Name = "lista_clientes";
            this.lista_clientes.Size = new System.Drawing.Size(543, 281);
            this.lista_clientes.TabIndex = 4;
            this.lista_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_clientes_CellContentClick);
            // 
            // Visualizar_Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 348);
            this.ControlBox = false;
            this.Controls.Add(this.lista_clientes);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btapagar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Visualizar_Excluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)(this.lista_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btapagar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.DataGridView lista_clientes;
    }
}