using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeSocialSociavel
{


    public partial class endereco : Form
    {
        private int idd;
        public endereco()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            listaendereco.Items.Clear();
            EnderecoDAO userDAO = new EnderecoDAO();
            List<UserEndereco> users = userDAO.SelectEndereco();

            try
            {
                if (users.Count > 0)
                {
                    foreach (UserEndereco userEndereco in users)
                    {
                        ListViewItem lv = new ListViewItem(userEndereco.Id.ToString());
                        lv.SubItems.Add(userEndereco.Rua);
                        lv.SubItems.Add(userEndereco.Numero);
                        lv.SubItems.Add(userEndereco.Bairro);
                        lv.SubItems.Add(userEndereco.CEP);
                        lv.SubItems.Add(userEndereco.Cidade);
                        lv.SubItems.Add(userEndereco.Estado);
                        listaendereco.Items.Add(lv);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void endereço_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = listaendereco.FocusedItem.Index;
            idd = int.Parse(listaendereco.Items[index].SubItems[0].Text);
            txbRua.Text = listaendereco.Items[index].SubItems[1].Text;
            txbNumero.Text = listaendereco.Items[index].SubItems[2].Text;
            txbBairro.Text = listaendereco.Items[index].SubItems[3].Text;
            txbCep.Text = listaendereco.Items[index].SubItems[4].Text;
            txbCidade.Text = listaendereco.Items[index].SubItems[5].Text;
            txbEstado.Text = listaendereco.Items[index].SubItems[6].Text;
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            UserEndereco userEndereco = new UserEndereco(
                idd,
                 txbRua.Text,
                 txbNumero.Text,
                 txbBairro.Text,
                 txbCep.Text,
                 txbCidade.Text,
                 txbEstado.Text
                 );

            //Chamando o método da classe User
            EnderecoDAO enderecoDAO = new EnderecoDAO();
            enderecoDAO.UpdateEndereco(userEndereco);
            //editar
            MessageBox.Show("Atualizado com sucesso",
               "AVISO",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            txbRua.Clear();
            txbNumero.Clear();
            txbBairro.Clear();
            txbCep.Clear();
            txbCidade.Clear();
            txbEstado.Clear();

            UpdateListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnderecoDAO enderecoDAO = new EnderecoDAO();
            enderecoDAO.DeleteEndereco(idd);

            txbRua.Clear();
            txbNumero.Clear();
            txbBairro.Clear();
            txbCep.Clear();
            txbCidade.Clear();
            txbEstado.Clear();

            UpdateListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Criar objeto da classe User
                UserEndereco userEndereco = new UserEndereco(
                txbRua.Text,
                txbNumero.Text,
                txbBairro.Text,
                txbCep.Text,
                txbCidade.Text,
                txbEstado.Text
                );

                //Chamando o método da classe User
                EnderecoDAO EnderecoDAO = new EnderecoDAO();
                EnderecoDAO.InsertEndereco(userEndereco);

                MessageBox.Show("Cadastrado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception error)

            {
                MessageBox.Show(error.Message);
            }

            txbRua.Clear();
            txbNumero.Clear();
            txbBairro.Clear();
            txbCep.Clear();
            txbCidade.Clear();
            txbEstado.Clear();
            UpdateListView();
        }

        private void listaendereco_MouseDoubleClick(object sender, MouseEventArgs e)
        {
         
        }


        private void listaendereco_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
