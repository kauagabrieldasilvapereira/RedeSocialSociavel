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
            try
            {
                //Criar objeto da classe User
                User user = new User(
                 txbNome.Text,
                 txbPront.Text,
                 txbSenha.Text
                 );
               
                //Chamando o método da classe User
                UserDAO userDAO = new UserDAO();
                userDAO.InsertUser(user);

                MessageBox.Show("Cadastro com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception error)

            {
                MessageBox.Show(error.Message);
            }

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

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
