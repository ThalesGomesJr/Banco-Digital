using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Banco_Digital
{
    public partial class Admistrativo : Form
    {
        public Admistrativo()
        {
            InitializeComponent();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair de Administrativo?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;


            else this.Close();
            
        }

        private void btinserir_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();
            inserir.ShowDialog();
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            Visualizar_Excluir visualizar = new Visualizar_Excluir();
            visualizar.ShowDialog();
        }
    }
}
