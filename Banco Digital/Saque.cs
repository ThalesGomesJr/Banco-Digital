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
    public partial class Saque : Form
    {
        public Saque()
        {
            InitializeComponent();
        }

        private void btsaque_Click(object sender, EventArgs e)
        {

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
                    string senha = linha["senha"].ToString();

                    if ((num_conta == tbnum_conta.Text) && (senha == tbsenha.Text))
                    {
                        float valor = float.Parse(tbvalor.Text);
                        float saldo = float.Parse(linha["saldo"].ToString());
                        string tipo_conta = linha["tipo_conta"].ToString();

                        if (tipo_conta == "Especial")
                        {
                            float saldo_atual = saldo - valor;

                            //parametros
                            comando.Parameters.AddWithValue("@saldo", saldo_atual);
                            comando.Parameters.AddWithValue("@num_conta", num_conta);
                            comando.Parameters.AddWithValue("@senha", senha);
                           
                            //texto da query
                            comando.CommandText = "UPDATE Cliente SET saldo = @saldo WHERE num_conta = @num_conta AND senha = @senha";

                            comando.ExecuteNonQuery();
                            comando.Dispose();
                            conexao.Dispose();

                            tbnum_conta.Text = "";
                            tbvalor.Text = "";
                            tbsenha.Text = "";
                            tbnum_conta.Focus();

                            MessageBox.Show("Saque realizado com Sucesso.", "Sucesso", MessageBoxButtons.OK);
                        }

                        else if (saldo >= valor)
                        {
                            float saldo_atual = saldo - valor;

                            //parametros
                            comando.Parameters.AddWithValue("@saldo", saldo_atual);
                            comando.Parameters.AddWithValue("@num_conta", num_conta);
                            comando.Parameters.AddWithValue("@senha", senha);

                            //texto da query
                            comando.CommandText = "UPDATE Cliente SET saldo = @saldo WHERE num_conta = @num_conta AND senha = @senha";

                            comando.ExecuteNonQuery();
                            comando.Dispose();
                            conexao.Dispose();

                            tbnum_conta.Text = "";
                            tbvalor.Text = "";
                            tbsenha.Text = "";
                            tbnum_conta.Focus();

                            MessageBox.Show("Saque realizado com Sucesso.", "Sucesso", MessageBoxButtons.OK);
                        }

                        else
                        {
                            MessageBox.Show("Saldo insulficiente.", "Erro", MessageBoxButtons.OK);
                            return;
                        }
                    }

                }
                
            }
            catch
            {
                MessageBox.Show("Aconteceu um erro na conexão com o Banco de Dados", "Erro", MessageBoxButtons.OK);
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
