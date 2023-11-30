using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;



namespace RedeSocialSociavel
{
    public partial class Tela_inicial : Form
    {
        public Tela_inicial()
        {
            //o initialize serve para ele iniciar o forms
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Assim que o botão da aba perfil for clicado ele entra na tela de admin onde é possivel o usuario mudar seu mome, email e senha 
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Tela_inicial_Load(object sender, EventArgs e)
        {

        }
    }
}

