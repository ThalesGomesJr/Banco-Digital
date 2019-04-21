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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair de cliente?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            else
                this.Close();
        }

        private void btdeposito_Click(object sender, EventArgs e)
        {
            Deposito deposito = new Deposito();
            deposito.ShowDialog();
        }

        private void btsaque_Click(object sender, EventArgs e)
        {
            Saque saque = new Saque();
            saque.ShowDialog();
        }
    }
}
