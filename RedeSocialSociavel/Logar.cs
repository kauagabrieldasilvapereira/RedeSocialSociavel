using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            string email = Email.Text;
            string senha = Senha.Text;
            
            UserDAO usuario = new UserDAO();

            if (usuario.LoginUser(email, senha)) {

                Admin telaInicial = new Admin();
                telaInicial.ShowDialog();
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro admin = new Cadastro();
            admin.ShowDialog();
        }
    }
}
