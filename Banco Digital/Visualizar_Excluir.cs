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
    public partial class Visualizar_Excluir : Form
    {
        int id_cliente;

        public Visualizar_Excluir()
        {
            InitializeComponent();
            ConstroiLista();
        }

        

        private void ConstroiLista()
        {
            try
            {
                SqlCeConnection conexao = new SqlCeConnection(@"Data Source = C:\Users\thale\Desktop\Curso C#\Databases\Banco Digital.sdf" + "; Password = 'root'");
                conexao.Open();

                string query = "SELECT * FROM Cliente";
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query,conexao);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                lista_clientes.DataSource = dados;
                
                //esconder colunas
                lista_clientes.Columns["id_cliente"].Visible = false;
                lista_clientes.Columns["senha"].Visible = false;

               
                //controla a disponibilidade dos comandos
                btapagar.Enabled = false;
                
                conexao.Dispose();
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

        private void btapagar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCeConnection conexao = new SqlCeConnection(@"Data Source = C:\Users\thale\Desktop\Curso C#\Databases\Banco Digital.sdf");
                conexao.Open();
                SqlCeCommand comando = new SqlCeCommand("DELETE FROM Cliente WHERE id_cliente = " + id_cliente, conexao);
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Dispose();

                //reconstruir a grelha de contactos
                ConstroiLista();

            }
            catch
            {
                MessageBox.Show("Aconteceu um erro na conexão com o Banco de Dados", "Erro", MessageBoxButtons.OK);
            }
        }

        private void lista_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_cliente = Convert.ToInt16(lista_clientes.Rows[e.RowIndex].Cells["id_cliente"].Value);
            btapagar.Enabled = true;
           
        }
    }
}

