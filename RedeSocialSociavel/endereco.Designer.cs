namespace RedeSocialSociavel
{
    partial class endereco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbCidade = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsent = new System.Windows.Forms.Button();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.txbCep = new System.Windows.Forms.TextBox();
            this.lblPront = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.idl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listaendereco = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txbCidade
            // 
            this.txbCidade.AsciiOnly = true;
            this.txbCidade.Location = new System.Drawing.Point(49, 199);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.PasswordChar = '*';
            this.txbCidade.Size = new System.Drawing.Size(99, 20);
            this.txbCidade.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(75, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cidade";
            // 
            // btnsent
            // 
            this.btnsent.ForeColor = System.Drawing.Color.DimGray;
            this.btnsent.Location = new System.Drawing.Point(59, 294);
            this.btnsent.Name = "btnsent";
            this.btnsent.Size = new System.Drawing.Size(75, 23);
            this.btnsent.TabIndex = 14;
            this.btnsent.Text = "Atualizar";
            this.btnsent.UseVisualStyleBackColor = true;
            this.btnsent.Click += new System.EventHandler(this.btnsent_Click);
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(48, 121);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(100, 20);
            this.txbBairro.TabIndex = 11;
            // 
            // txbCep
            // 
            this.txbCep.Location = new System.Drawing.Point(47, 160);
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(100, 20);
            this.txbCep.TabIndex = 12;
            // 
            // lblPront
            // 
            this.lblPront.AutoSize = true;
            this.lblPront.BackColor = System.Drawing.Color.White;
            this.lblPront.ForeColor = System.Drawing.Color.Black;
            this.lblPront.Location = new System.Drawing.Point(81, 144);
            this.lblPront.Name = "lblPront";
            this.lblPront.Size = new System.Drawing.Size(28, 13);
            this.lblPront.TabIndex = 16;
            this.lblPront.Text = "CEP";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(81, 105);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(34, 13);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Bairro";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(59, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Excluir ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(48, 82);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(75, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Numero";
            // 
            // txbRua
            // 
            this.txbRua.Location = new System.Drawing.Point(48, 43);
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(100, 20);
            this.txbRua.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(81, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Rua ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(75, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Estado ";
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(47, 238);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(100, 20);
            this.txbEstado.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(59, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cadastar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idl
            // 
            this.idl.Text = "id";
            // 
            // rua
            // 
            this.rua.Text = "rua";
            // 
            // numero
            // 
            this.numero.Text = "numero";
            // 
            // cep
            // 
            this.cep.Text = "estado";
            // 
            // cidade
            // 
            this.cidade.Text = "numero";
            // 
            // estado
            // 
            this.estado.Text = "bairro";
            // 
            // bairro
            // 
            this.bairro.Text = "cidade";
            // 
            // listaendereco
            // 
            this.listaendereco.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idl,
            this.rua,
            this.numero,
            this.cep,
            this.cidade,
            this.estado,
            this.bairro});
            this.listaendereco.HideSelection = false;
            this.listaendereco.Location = new System.Drawing.Point(222, 43);
            this.listaendereco.Name = "listaendereco";
            this.listaendereco.Size = new System.Drawing.Size(480, 303);
            this.listaendereco.TabIndex = 19;
            this.listaendereco.UseCompatibleStateImageBehavior = false;
            this.listaendereco.View = System.Windows.Forms.View.Details;
            this.listaendereco.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listaendereco.DoubleClick += new System.EventHandler(this.listaendereco_DoubleClick);
            this.listaendereco.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listaendereco_MouseDoubleClick);
            // 
            // endereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txbEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbRua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaendereco);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsent);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.txbCep);
            this.Controls.Add(this.lblPront);
            this.Controls.Add(this.lblNome);
            this.Name = "endereco";
            this.Text = "endereço";
            this.Load += new System.EventHandler(this.endereço_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txbCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsent;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.TextBox txbCep;
        private System.Windows.Forms.Label lblPront;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbRua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader rua;
        private System.Windows.Forms.ColumnHeader numero;
        private System.Windows.Forms.ColumnHeader cep;
        private System.Windows.Forms.ColumnHeader cidade;
        private System.Windows.Forms.ColumnHeader estado;
        private System.Windows.Forms.ColumnHeader bairro;
        private System.Windows.Forms.ListView listaendereco;
        private System.Windows.Forms.ColumnHeader idl;
    }
}