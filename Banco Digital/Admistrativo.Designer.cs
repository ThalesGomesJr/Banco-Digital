namespace Banco_Digital
{
    partial class Admistrativo
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
            this.label2 = new System.Windows.Forms.Label();
            this.btsair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btinserir = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "v1.0.0";
            // 
            // btsair
            // 
            this.btsair.Location = new System.Drawing.Point(118, 294);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(174, 33);
            this.btsair.TabIndex = 3;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(115, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Administrativo";
            // 
            // btinserir
            // 
            this.btinserir.Location = new System.Drawing.Point(118, 167);
            this.btinserir.Name = "btinserir";
            this.btinserir.Size = new System.Drawing.Size(174, 33);
            this.btinserir.TabIndex = 0;
            this.btinserir.Text = "Inserir Cliente";
            this.btinserir.UseVisualStyleBackColor = true;
            this.btinserir.Click += new System.EventHandler(this.btinserir_Click);
            // 
            // bteditar
            // 
            this.bteditar.Location = new System.Drawing.Point(118, 233);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(174, 33);
            this.bteditar.TabIndex = 1;
            this.bteditar.Text = "Visualiazar/Excluir Cliente";
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // Admistrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(410, 372);
            this.ControlBox = false;
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btinserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admistrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admistrativo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btinserir;
        private System.Windows.Forms.Button bteditar;
    }
}