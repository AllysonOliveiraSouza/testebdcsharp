using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TesteBD
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

       private String strconexao = "server=localhost;port=3306;UID=root;database=testebdcsharp;pwd=;";

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try {

                String nome = txtNome.Text;

            MySqlConnection conexao = new MySqlConnection(strconexao);
                conexao.Open();
                MySqlCommand comandoSQL = new MySqlCommand("insert into usuario(nome) values ('"+nome+"');",conexao);
                comandoSQL.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Usuário cadastrado!");
                txtNome.Clear();
            }
            catch(Exception ex) { 
            MessageBox.Show("Ocorreu um erro !\n"+ex);
            }

        }
    }
}
