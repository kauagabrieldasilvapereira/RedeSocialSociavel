﻿using Projeto1;
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


    public partial class Cadastro : Form
    {
        private int id;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnsent_Click(object sender, EventArgs e)
            //esse botao serve para cadastrar o usuario
        {
            try
            {
                //Criar objeto da classe User
                User user = new User(
                 id,
                 txbNome.Text,
                 txbPront.Text,
                 txbSenha.Text
                 );

                //Chamando o método da classe User
                UserDAO userDAO = new UserDAO();
                userDAO.InsertUser(user);

                MessageBox.Show("Cadastrado com sucesso",
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
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // a partir desse botao podemos voltar para a aba login(caso quisermos), pois assim que é cadastrado o usuario ele ja nos leva para la
            Logar Logar = new Logar();
            Logar.ShowDialog();

        }

        private void txbPront_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            endereco endereço = new endereco();
            endereço.ShowDialog();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}


