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
    public partial class LoginAdministrativo : Form
    {
        bool login = false;

        public LoginAdministrativo()
        {
            InitializeComponent();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btentrar_Click(object sender, EventArgs e)
        {
            
            try {
                
                SqlCeConnection conexao = new SqlCeConnection(@"Data Source = C:\Users\thale\Desktop\Curso C#\Databases\Banco Digital.sdf"+"; Password = 'root'");
                conexao.Open();

                DataTable dados = new DataTable();

                string query = "SELECT nome,senha FROM Administrativo";
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, conexao);

                adaptador.Fill(dados);

                conexao.Close();
                

                foreach (DataRow linha in dados.Rows)
                {
                    string nome = linha["nome"].ToString();
                    string senha = linha["senha"].ToString();

                    if ((tbnome.Text == nome)&&(tbsenha.Text == senha))
                    {
                        login = true;
                    }
                }

                if (login == true)
                {
                    tbnome.Text = "";
                    tbsenha.Text = "";
                    tbnome.Focus();
                    Admistrativo entrar = new Admistrativo();
                    entrar.ShowDialog();
                }
                else
                    MessageBox.Show("Erro no login \nTente novamente!", "ERRO", MessageBoxButtons.OK);   
            }
            catch
            {
                MessageBox.Show("Erro ao conectar ao Banco de Dados", "ERRO", MessageBoxButtons.OK);
            }
        }
    }
}
