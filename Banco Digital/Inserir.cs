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
    public partial class Inserir : Form
    {
        int id_cliente;

        public Inserir(int id_cliente = -1)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btinserir_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCeConnection conexao = new SqlCeConnection(@"Data Source = C:\Users\thale\Desktop\Curso C#\Databases\Banco Digital.sdf" + "; Password = 'root'");
                conexao.Open();
                
                //verifica se os campos estão preechidos.
                if (tbnome.Text == "" || tbconta.Text =="" ||tbsenha.Text == "" || tbnum_conta.Text=="" || tbcpf.Text=="" || tbtelefone.Text == "")
                {
                    MessageBox.Show("Falta preencher todos os campos.");
                    return;
                }

                if (tbsaldo.Text == "")
                    tbsaldo.Text = 0.ToString();


                //transforma o saldo em float
                float saldo = float.Parse(tbsaldo.Text);
                
                //buscar o id_cliente disponivel
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT MAX(id_cliente) AS maxid FROM Cliente", conexao);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                //verifica se o valor é nulo
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                    id_cliente = 0;
                else
                    id_cliente = Convert.ToInt16(dados.Rows[0][0]) + 1;

                //gravar a nova conta na base de dados
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                //parametros
                comando.Parameters.AddWithValue("@id_cliente", id_cliente);
                comando.Parameters.AddWithValue("@nome", tbnome.Text);
                comando.Parameters.AddWithValue("@num_conta", tbnum_conta.Text);
                comando.Parameters.AddWithValue("@saldo", saldo);
                comando.Parameters.AddWithValue("@senha", tbsenha.Text);
                comando.Parameters.AddWithValue("@tipo_conta",tbconta.Text);
                comando.Parameters.AddWithValue("@cpf", tbcpf.Text);
                comando.Parameters.AddWithValue("@telefone", tbtelefone.Text);

                //verifica se já existe um cliente com o mesmo num_conta ou cpf
                adaptador = new SqlCeDataAdapter();
                dados = new DataTable();
                comando.CommandText = "SELECT * FROM Cliente WHERE  num_conta = @num_conta OR cpf = @cpf";
                adaptador.SelectCommand = comando;
                adaptador.Fill(dados);
                if (dados.Rows.Count != 0)
                {
                    MessageBox.Show("Já existe um registo com esses dados.","ERRO",MessageBoxButtons.OK);
                    return;
                }

                //texto da query
                comando.CommandText = "INSERT INTO Cliente VALUES(" +
                    "@id_cliente, @nome, @num_conta,@saldo,@senha,@tipo_conta,@cpf,@telefone)";

                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Dispose();

                MessageBox.Show("Cliente adicionado com sucesso.","Sucesso",MessageBoxButtons.OK);

                //limpa campos
                tbnome.Text = "";
                tbnum_conta.Text = "";
                tbsaldo.Text = "";
                tbsenha.Text = "";
                tbconta.Text = "";
                tbcpf.Text = "";
                tbtelefone.Text = "";
                tbnome.Focus();
            }
            
            catch
            {
                MessageBox.Show("Aconteceu um erro na conexão com o Banco de Dados","Erro",MessageBoxButtons.OK);
            }
        }
    }
}
