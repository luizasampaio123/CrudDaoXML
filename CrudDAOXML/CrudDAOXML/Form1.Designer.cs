namespace CrudDAOXML
{
    partial class Crud
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_nome = new Label();
            label_email = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_cadastrar = new Button();
            btn_alterar = new Button();
            dataGridView2 = new DataGridView();
            btn_excluir = new Button();
            labelAlterar = new Label();
            textBox3 = new TextBox();
            btn_concluido = new Button();
            textBox4 = new TextBox();
            label_remover = new Label();
            btn_concluido_excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label_nome
            // 
            label_nome.AutoSize = true;
            label_nome.Location = new Point(376, 246);
            label_nome.Name = "label_nome";
            label_nome.Size = new Size(50, 20);
            label_nome.TabIndex = 0;
            label_nome.Text = "Nome";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(376, 354);
            label_email.Name = "label_email";
            label_email.Size = new Size(46, 20);
            label_email.TabIndex = 1;
            label_email.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(376, 283);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(659, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(376, 390);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(659, 27);
            textBox2.TabIndex = 3;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(376, 456);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(200, 29);
            btn_cadastrar.TabIndex = 4;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(604, 456);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(197, 29);
            btn_alterar.TabIndex = 5;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1145, 102);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(793, 524);
            dataGridView2.TabIndex = 7;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(829, 456);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(206, 29);
            btn_excluir.TabIndex = 5;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // labelAlterar
            // 
            labelAlterar.AutoSize = true;
            labelAlterar.Location = new Point(376, 159);
            labelAlterar.Name = "labelAlterar";
            labelAlterar.Size = new Size(320, 20);
            labelAlterar.TabIndex = 8;
            labelAlterar.Text = "Digite o nome do cliente que você quer alterar";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(376, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(659, 27);
            textBox3.TabIndex = 9;
            // 
            // btn_concluido
            // 
            btn_concluido.Location = new Point(601, 512);
            btn_concluido.Name = "btn_concluido";
            btn_concluido.Size = new Size(200, 29);
            btn_concluido.TabIndex = 10;
            btn_concluido.Text = "Concluido";
            btn_concluido.UseVisualStyleBackColor = true;
            btn_concluido.Click += btn_concluido_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(376, 283);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(659, 27);
            textBox4.TabIndex = 11;
            // 
            // label_remover
            // 
            label_remover.AutoSize = true;
            label_remover.Location = new Point(554, 260);
            label_remover.Name = "label_remover";
            label_remover.Size = new Size(268, 20);
            label_remover.TabIndex = 12;
            label_remover.Text = "Digite o cliente que você quer remover";
            // 
            // btn_concluido_excluir
            // 
            btn_concluido_excluir.Location = new Point(601, 331);
            btn_concluido_excluir.Name = "btn_concluido_excluir";
            btn_concluido_excluir.Size = new Size(200, 29);
            btn_concluido_excluir.TabIndex = 13;
            btn_concluido_excluir.Text = "Concluido";
            btn_concluido_excluir.UseVisualStyleBackColor = true;
            btn_concluido_excluir.Click += btn_concluido_excluir_Click;
            // 
            // Crud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2028, 855);
            Controls.Add(btn_concluido_excluir);
            Controls.Add(label_remover);
            Controls.Add(textBox4);
            Controls.Add(btn_concluido);
            Controls.Add(textBox3);
            Controls.Add(labelAlterar);
            Controls.Add(dataGridView2);
            Controls.Add(btn_excluir);
            Controls.Add(btn_alterar);
            Controls.Add(btn_cadastrar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label_email);
            Controls.Add(label_nome);
            Name = "Crud";
            Text = "Cadastro de Clientes";
            Load += Crud_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_nome;
        private Label label_email;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_cadastrar;
        private Button btn_alterar;
        private DataGridView dataGridView2;
        private Button btn_excluir;
        private Label labelAlterar;
        private TextBox textBox3;
        private Button btn_concluido;
        private TextBox textBox4;
        private Label label_remover;
        private Button btn_concluido_excluir;
    }
}
