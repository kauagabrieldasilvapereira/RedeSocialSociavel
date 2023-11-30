using Projeto1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RedeSocialSociavel
{
    public partial class Admin : Form
    {
        private int id;
        public Admin()
        {
            InitializeComponent();
            UpdateListView();
        }

        private void UpdateListView()
        {
            listadmin.Items.Clear();
            UserDAO userDAO = new UserDAO();
            List<User> users = userDAO.SelectUser();

            try
            {
                if (users.Count > 0)
                {
                    foreach (User user in users)
                    {
                        ListViewItem lv = new ListViewItem(user.Id.ToString());
                        lv.SubItems.Add(user.Nome);
                        lv.SubItems.Add(user.Email);
                        lv.SubItems.Add(user.Senha);
                        listadmin.Items.Add(lv);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void listadmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listadmin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listadmin.FocusedItem.Index;
            id = int.Parse(listadmin.Items[index].SubItems[0].Text);
            txbNome.Text = listadmin.Items[index].SubItems[1].Text;
            txbPront.Text = listadmin.Items[index].SubItems[2].Text;

        }

        private void btnsent_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chamando método de exclusão

            UserDAO userDAO = new UserDAO();
            userDAO.DelelteUser(id);

            //limpando campos
            txbNome.Clear();
            txbSenha.Clear();
            txbPront.Clear();
            //atualizando listview
            UpdateListView();
        }

        private void btnsent_Click_1(object sender, EventArgs e)
        {
            //editar
            User user = new User(id,
                 txbNome.Text,
                 txbPront.Text,
                 txbSenha.Text
                 );

            //Chamando o método da classe User
            UserDAO userDAO = new UserDAO();
            userDAO.UpdateUser(user);
            //editar
            MessageBox.Show("Atualizado com sucesso",
               "AVISO",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            txbNome.Clear();
            txbSenha.Clear();
            txbPront.Clear();

            UpdateListView();

        }
        private void button3_Click(object sender, EventArgs e)
        {

            UserDAO userDAO = new UserDAO();
            userDAO.DelelteUser(id);

            txbNome.Clear();
            txbSenha.Clear();
            txbPront.Clear();

            UpdateListView();
        }

        private void listadmin_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txbPront_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //aqui temos o botao de gera o pdf a partir das colunas do nosso banco de dados 
            // Conexão com o banco de dados SQL Server
            string stringConnection = @"Data Source="
                     + Environment.MachineName +
                     @"\SQLEXPRESS;Initial Catalog=" +
                     "RedeSocialSociavel" + ";Integrated Security=true";
            SqlConnection connection = new SqlConnection(stringConnection);
            connection.Open();

            // Consulta SQL para recuperar as informações
            string query = "SELECT nnCliente, emailCliente, senhaCliente FROM login";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            // Cria um novo documento PDF
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("arquivo.pdf", FileMode.Create));
            document.Open();

            // Cria uma nova tabela e adiciona as informações recuperadas
            PdfPTable table = new PdfPTable(3);
            table.AddCell("Nome");
            table.AddCell("Email");
            table.AddCell("Senha");

            while (reader.Read())
            {
                table.AddCell(reader["nnCliente"].ToString());
                table.AddCell(reader["emailCliente"].ToString());
                table.AddCell(reader["senhaCliente"].ToString());
            }

            // Adiciona a tabela ao documento
            document.Add(table);

            // Fecha o documento e a conexão com o banco de dados
            document.Close();
            connection.Close();

                MessageBox.Show(
                "RELATORIO GERADO COM SUCESSO",
                "ATENÇÃO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
    }






