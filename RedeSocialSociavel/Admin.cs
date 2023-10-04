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
        }

        private void UpdateListView()
        {
            listadmin.Items.Clear();

            Conection conn = new Conection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM login";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["id"];
                    string name = (string)dr["nnCliente"];
                    string email = (string)dr["emailCliente"];
                    string pass = (string)dr["senhaCliente"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(email);
                    lv.SubItems.Add(pass);
                    listadmin.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
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

            Conection connection = new Conection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM login WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();

                txbNome.Clear();
                txbSenha.Clear();
                txbPront.Clear();

                UpdateListView();

            }

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}

