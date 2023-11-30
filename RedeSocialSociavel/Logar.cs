using Projeto1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeSocialSociavel
{
    public partial class Logar : Form
    {
        public Logar()
        {
            //o initialize serve para ele iniciar o forms
            InitializeComponent();
        }

        private void Cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //esse botão login da aba logar serve para entrar na tela inicial e mostrar tambem a mensagem de Seja bem vindo, assim como, se o usuario ou
            //senha estiverem digitados errados ele mostra a mensasgem de que foi não foi preenchido corretamente
            //o conection abre a conexão com banco de dados para o select ler as colunas da tabela 
            //é nesta aba também que temos a criptografia de senha 

            Conection conn = new Conection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM login WHERE nnCliente = @Usuario";
            sqlCom.Parameters.AddWithValue("@Usuario", Nome.Text);

            if (Nome.Text == "")
            {
                MessageBox.Show(
                "O usuario ou senha não foram preenchidos corretamente",
                "ATENÇÃO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                Nome.Clear();
                Senha.Clear();
            }

            using (SqlDataReader reader = sqlCom.ExecuteReader())
            // Ele usa um objeto SqlDataReader para ler as linhas retornadas pela consulta SQL e itera sobre cada linha. Para cada linha,
            // ele recupera o valor da coluna “SenhaCliente” e armazena-o na variável senhasgbd. Em seguida,
            // ele armazena o valor do campo de senha do usuário na variável senhalogin. Depois,
            // ele cria um objeto SHA256 que será usado para calcular o hash da senha do usuário.
            // Ele calcula o hash da senha do usuário e armazena-o em um array de bytes.
            // Em seguida, ele converte cada byte do hash da senha em uma string hexadecimal e adiciona-o a um objeto StringBuilder.
            // Por fim, ele armazena a representação hexadecimal do hash da senha na variável sha256login.
            {
                while (reader.Read())
                {
                    string senhasgbd = (string)reader["SenhaCliente"];

                    string senhalogin = Senha.Text;
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senhalogin));
                        StringBuilder sb = new StringBuilder();
                        foreach (byte b in bytes)
                        {
                            sb.Append(b.ToString("x2"));
                        }
                        string sha256login = sb.ToString();

                        if (senhasgbd == sha256login)
                        {
                            MessageBox.Show(
                            "SEJA BEM - VINDO",
                            "ATENÇÃO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            Nome.Clear();
                            Senha.Clear();

                            Tela_inicial tela_Inicial = new Tela_inicial();
                            tela_Inicial.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(
                            "O usuario ou senha não foram preenchidos corretamente",
                            "ATENÇÃO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            Senha.Clear();
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //aqui ele entra na aba admin a partir do boão admin 
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //aqui atraves do linklabel ele entra na aba cadastro caso vc n tenha nenhum cadastro no sistema
            Cadastro Cadastro = new Cadastro();
            Cadastro.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logar_Load(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
