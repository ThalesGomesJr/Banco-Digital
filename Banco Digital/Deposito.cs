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
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btdeposito_Click(object sender, EventArgs e)
        {
            bool sucesso = false;
            try
            {
                SqlCeConnection conexao = new SqlCeConnection(@"Data Source = C:\Users\thale\Desktop\Curso C#\Databases\Banco Digital.sdf" + "; Password = 'root'");
                conexao.Open();

                string query = "SELECT * FROM Cliente";
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, conexao);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                foreach (DataRow linha in dados.Rows)
                {
                    string num_conta = linha["num_conta"].ToString();

                    if (num_conta == tbnum_conta.Text)
                    {
                        float valor = float.Parse(tbvalor.Text);
                        float saldo = float.Parse(linha["saldo"].ToString());

                        float saldo_atual = saldo + valor;
                        
                        //parametros
                        comando.Parameters.AddWithValue("@saldo",saldo_atual);
                        comando.Parameters.AddWithValue("@num_conta", num_conta);
 
                        //texto da query
                        comando.CommandText = "UPDATE Cliente SET saldo = @saldo WHERE num_conta = @num_conta";

                        comando.ExecuteNonQuery();
                        comando.Dispose();
                        conexao.Dispose();
                        sucesso = true;

                        tbnum_conta.Text = "";
                        tbvalor.Text = "";
                        tbnum_conta.Focus();
                    }
                }

                if(sucesso)
                    MessageBox.Show("Deposito realizado com Sucesso.", "Sucesso", MessageBoxButtons.OK);

                else
                {
                    MessageBox.Show("Esta conta não existe.", "Erro", MessageBoxButtons.OK);
                    return;
                }
                
            }
            catch
            {
                MessageBox.Show("Aconteceu um erro na conexão com o Banco de Dados", "Erro", MessageBoxButtons.OK);
            }
        }
    }
}
