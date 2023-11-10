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
                foreach (User user in users)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Email);
                    lv.SubItems.Add(user.Senha);
                    listadmin.Items.Add(lv);
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
            txbSenha.Text = listadmin.Items[index].SubItems[3].Text;

        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            Conection connection = new Conection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE login SET
                nnCliente = @nome, 
                emailCliente = @email, 
                senhaCliente = @senha                
                WHERE id = @id";

            sqlCommand.Parameters.AddWithValue("@nome", txbNome.Text);
            sqlCommand.Parameters.AddWithValue("@email", txbPront.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txbSenha.Text);
            sqlCommand.Parameters.AddWithValue("@id", id);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txbNome.Clear();
            txbSenha.Clear();
            txbPront.Clear();

            UpdateListView();
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

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }


}


