using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Digital
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            else
                Application.Exit();
        }

        private void btcliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }

        private void btadmin_Click(object sender, EventArgs e)
        {
            LoginAdministrativo login = new LoginAdministrativo();
            login.ShowDialog();
            
        }

        
    }
}
