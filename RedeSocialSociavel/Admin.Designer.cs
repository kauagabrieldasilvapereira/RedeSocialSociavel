namespace RedeSocialSociavel
{
    partial class Admin
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
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnsent = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbPront = new System.Windows.Forms.TextBox();
            this.lblPront = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.listadmin = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(612, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(629, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Senha ";
            // 
            // txbSenha
            // 
            this.txbSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbSenha.Location = new System.Drawing.Point(602, 218);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(100, 20);
            this.txbSenha.TabIndex = 2;
            // 
            // btnsent
            // 
            this.btnsent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsent.Location = new System.Drawing.Point(612, 244);
            this.btnsent.Name = "btnsent";
            this.btnsent.Size = new System.Drawing.Size(75, 23);
            this.btnsent.TabIndex = 3;
            this.btnsent.Text = "Cadastrar\r\n";
            this.btnsent.UseVisualStyleBackColor = true;
            this.btnsent.Click += new System.EventHandler(this.btnsent_Click_1);
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txbNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbNome.Location = new System.Drawing.Point(602, 140);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 0;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // txbPront
            // 
            this.txbPront.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbPront.Location = new System.Drawing.Point(602, 179);
            this.txbPront.Name = "txbPront";
            this.txbPront.Size = new System.Drawing.Size(100, 20);
            this.txbPront.TabIndex = 1;
            this.txbPront.TextChanged += new System.EventHandler(this.txbPront_TextChanged);
            // 
            // lblPront
            // 
            this.lblPront.AutoSize = true;
            this.lblPront.BackColor = System.Drawing.Color.Black;
            this.lblPront.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPront.Location = new System.Drawing.Point(634, 163);
            this.lblPront.Name = "lblPront";
            this.lblPront.Size = new System.Drawing.Size(36, 13);
            this.lblPront.TabIndex = 30;
            this.lblPront.Text = "E-Mail";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Black;
            this.lblNome.ForeColor = System.Drawing.Color.Transparent;
            this.lblNome.Location = new System.Drawing.Point(632, 124);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 29;
            this.lblNome.Text = "Nome ";
            // 
            // listadmin
            // 
            this.listadmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listadmin.FullRowSelect = true;
            this.listadmin.HideSelection = false;
            this.listadmin.Location = new System.Drawing.Point(98, 94);
            this.listadmin.Name = "listadmin";
            this.listadmin.Size = new System.Drawing.Size(443, 263);
            this.listadmin.TabIndex = 28;
            this.listadmin.UseCompatibleStateImageBehavior = false;
            this.listadmin.View = System.Windows.Forms.View.Details;
            this.listadmin.SelectedIndexChanged += new System.EventHandler(this.listadmin_SelectedIndexChanged_1);
            this.listadmin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listadmin_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 106;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.btnsent);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbPront);
            this.Controls.Add(this.lblPront);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.listadmin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btnsent;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbPront;
        private System.Windows.Forms.Label lblPront;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ListView listadmin;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
    }
}