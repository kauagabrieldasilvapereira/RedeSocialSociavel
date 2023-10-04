using Projeto1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeSocialSociavel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            Conection conection = new Conection();
            SqlCommand sqlComand = new SqlCommand();

            sqlComand.Connection = conection.ReturnConnection();
            sqlComand.CommandText = @"INSERT INTO login VALUES (@nome, @email, @senha)";

            sqlComand.Parameters.AddWithValue("@nome", txbNome.Text);
            sqlComand.Parameters.AddWithValue("@email", txbPront.Text);
            sqlComand.Parameters.AddWithValue("@senha", txbSenha.Text);

            sqlComand.ExecuteNonQuery();

            MessageBox.Show("Cadastro com sucesso)",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txbNome.Clear();
            txbPront.Clear();
            txbSenha.Clear();
            txbNome.Clear();
            txbNome.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }
    }
}
