namespace SistemaCadastro
{
    partial class Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.btnRemoveLivro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgLivros = new System.Windows.Forms.DataGridView();
            this.tabRegistrar = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtedicao = new System.Windows.Forms.TextBox();
            this.txteditora = new System.Windows.Forms.TextBox();
            this.txtnumeroPaginas = new System.Windows.Forms.TextBox();
            this.txtanoPublicacao = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAdicionar = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLivros)).BeginInit();
            this.tabRegistrar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAdicionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnBusca);
            this.panel1.Controls.Add(this.btnCadastra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 530);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(24, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 64);
            this.button1.TabIndex = 11;
            this.button1.Text = "Adicionar Autor";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.Transparent;
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBusca.ForeColor = System.Drawing.Color.White;
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(24, 366);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(161, 60);
            this.btnBusca.TabIndex = 5;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnCadastra
            // 
            this.btnCadastra.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastra.FlatAppearance.BorderSize = 0;
            this.btnCadastra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCadastra.ForeColor = System.Drawing.Color.White;
            this.btnCadastra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastra.Location = new System.Drawing.Point(24, 224);
            this.btnCadastra.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(161, 60);
            this.btnCadastra.TabIndex = 3;
            this.btnCadastra.Text = "Registrar Livro";
            this.btnCadastra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastra.UseVisualStyleBackColor = false;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(726, 32);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 16);
            this.lblMensagem.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1020, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 80);
            this.button2.TabIndex = 8;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.Lavender;
            this.tabBuscar.Controls.Add(this.btnRemoveLivro);
            this.tabBuscar.Controls.Add(this.label5);
            this.tabBuscar.Controls.Add(this.txtBusca);
            this.tabBuscar.Controls.Add(this.dgLivros);
            this.tabBuscar.ForeColor = System.Drawing.Color.Black;
            this.tabBuscar.Location = new System.Drawing.Point(4, 30);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Size = new System.Drawing.Size(832, 386);
            this.tabBuscar.TabIndex = 1;
            this.tabBuscar.Text = "Buscar";
            // 
            // btnRemoveLivro
            // 
            this.btnRemoveLivro.AccessibleName = "RemoveLivro";
            this.btnRemoveLivro.FlatAppearance.BorderSize = 0;
            this.btnRemoveLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveLivro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveLivro.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveLivro.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveLivro.Image")));
            this.btnRemoveLivro.Location = new System.Drawing.Point(636, 13);
            this.btnRemoveLivro.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveLivro.Name = "btnRemoveLivro";
            this.btnRemoveLivro.Size = new System.Drawing.Size(160, 60);
            this.btnRemoveLivro.TabIndex = 16;
            this.btnRemoveLivro.Text = "Remover";
            this.btnRemoveLivro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveLivro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveLivro.UseVisualStyleBackColor = true;
            this.btnRemoveLivro.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Titulo do Livro:";
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.SystemColors.Info;
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBusca.Location = new System.Drawing.Point(195, 28);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(394, 32);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dgLivros
            // 
            this.dgLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLivros.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLivros.Location = new System.Drawing.Point(16, 97);
            this.dgLivros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgLivros.Name = "dgLivros";
            this.dgLivros.ReadOnly = true;
            this.dgLivros.RowHeadersWidth = 51;
            this.dgLivros.RowTemplate.Height = 29;
            this.dgLivros.Size = new System.Drawing.Size(797, 233);
            this.dgLivros.TabIndex = 0;
            this.dgLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLivros_CellContentClick);
            // 
            // tabRegistrar
            // 
            this.tabRegistrar.BackColor = System.Drawing.Color.Lavender;
            this.tabRegistrar.Controls.Add(this.button4);
            this.tabRegistrar.Controls.Add(this.label12);
            this.tabRegistrar.Controls.Add(this.txtedicao);
            this.tabRegistrar.Controls.Add(this.txteditora);
            this.tabRegistrar.Controls.Add(this.txtnumeroPaginas);
            this.tabRegistrar.Controls.Add(this.txtanoPublicacao);
            this.tabRegistrar.Controls.Add(this.txttitulo);
            this.tabRegistrar.Controls.Add(this.label11);
            this.tabRegistrar.Controls.Add(this.cbAutor);
            this.tabRegistrar.Controls.Add(this.label6);
            this.tabRegistrar.Controls.Add(this.BtnConfirmaCadastro);
            this.tabRegistrar.Controls.Add(this.label3);
            this.tabRegistrar.Controls.Add(this.label2);
            this.tabRegistrar.Controls.Add(this.label4);
            this.tabRegistrar.ForeColor = System.Drawing.Color.Black;
            this.tabRegistrar.Location = new System.Drawing.Point(4, 30);
            this.tabRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(4);
            this.tabRegistrar.Size = new System.Drawing.Size(832, 386);
            this.tabRegistrar.TabIndex = 0;
            this.tabRegistrar.Text = "Registrar Livro";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lavender;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(566, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 45);
            this.button4.TabIndex = 20;
            this.button4.Text = "     Registrar Novo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(562, 116);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "Edição:";
            // 
            // txtedicao
            // 
            this.txtedicao.BackColor = System.Drawing.SystemColors.Info;
            this.txtedicao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtedicao.Location = new System.Drawing.Point(671, 111);
            this.txtedicao.Margin = new System.Windows.Forms.Padding(4);
            this.txtedicao.Name = "txtedicao";
            this.txtedicao.Size = new System.Drawing.Size(98, 34);
            this.txtedicao.TabIndex = 18;
            this.txtedicao.TextChanged += new System.EventHandler(this.txtedicao_TextChanged);
            // 
            // txteditora
            // 
            this.txteditora.BackColor = System.Drawing.SystemColors.Info;
            this.txteditora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txteditora.Location = new System.Drawing.Point(117, 109);
            this.txteditora.Margin = new System.Windows.Forms.Padding(4);
            this.txteditora.Name = "txteditora";
            this.txteditora.Size = new System.Drawing.Size(408, 34);
            this.txteditora.TabIndex = 17;
            this.txteditora.TextChanged += new System.EventHandler(this.txteditora_TextChanged);
            // 
            // txtnumeroPaginas
            // 
            this.txtnumeroPaginas.BackColor = System.Drawing.SystemColors.Info;
            this.txtnumeroPaginas.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtnumeroPaginas.Location = new System.Drawing.Point(671, 38);
            this.txtnumeroPaginas.Name = "txtnumeroPaginas";
            this.txtnumeroPaginas.Size = new System.Drawing.Size(98, 32);
            this.txtnumeroPaginas.TabIndex = 12;
            // 
            // txtanoPublicacao
            // 
            this.txtanoPublicacao.BackColor = System.Drawing.SystemColors.Info;
            this.txtanoPublicacao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtanoPublicacao.Location = new System.Drawing.Point(240, 255);
            this.txtanoPublicacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtanoPublicacao.Name = "txtanoPublicacao";
            this.txtanoPublicacao.Size = new System.Drawing.Size(285, 32);
            this.txtanoPublicacao.TabIndex = 11;
            this.txtanoPublicacao.TextChanged += new System.EventHandler(this.txtanoPublicacao_TextChanged);
            // 
            // txttitulo
            // 
            this.txttitulo.BackColor = System.Drawing.SystemColors.Info;
            this.txttitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txttitulo.Location = new System.Drawing.Point(117, 38);
            this.txttitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(408, 34);
            this.txttitulo.TabIndex = 9;
            this.txttitulo.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(16, 118);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "Editora:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cbAutor
            // 
            this.cbAutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAutor.BackColor = System.Drawing.SystemColors.Info;
            this.cbAutor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(117, 177);
            this.cbAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(408, 36);
            this.cbAutor.TabIndex = 10;
            this.cbAutor.SelectedIndexChanged += new System.EventHandler(this.cbGenero_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(562, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Páginas:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.Black;
            this.BtnConfirmaCadastro.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfirmaCadastro.Image")));
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(346, 312);
            this.BtnConfirmaCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(170, 50);
            this.BtnConfirmaCadastro.TabIndex = 13;
            this.BtnConfirmaCadastro.Text = "Cadastrar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = true;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ano de Publicação:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Autor(a):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titulo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabRegistrar);
            this.tabControl1.Controls.Add(this.tabAdicionar);
            this.tabControl1.Controls.Add(this.tabBuscar);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(247, 97);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 420);
            this.tabControl1.TabIndex = 9;
            // 
            // tabAdicionar
            // 
            this.tabAdicionar.BackColor = System.Drawing.Color.Lavender;
            this.tabAdicionar.Controls.Add(this.button3);
            this.tabAdicionar.Controls.Add(this.txtnome);
            this.tabAdicionar.Controls.Add(this.label1);
            this.tabAdicionar.Location = new System.Drawing.Point(4, 30);
            this.tabAdicionar.Name = "tabAdicionar";
            this.tabAdicionar.Size = new System.Drawing.Size(832, 386);
            this.tabAdicionar.TabIndex = 2;
            this.tabAdicionar.Text = "Adicionar Autor";
            this.tabAdicionar.Click += new System.EventHandler(this.tabRegistrar2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(275, 280);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 90);
            this.button3.TabIndex = 24;
            this.button3.Text = "Cadastrar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.SystemColors.Info;
            this.txtnome.Location = new System.Drawing.Point(275, 132);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(270, 32);
            this.txtnome.TabIndex = 23;
            this.txtnome.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Novo Autor(a):";
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1100, 530);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLivros)).EndInit();
            this.tabRegistrar.ResumeLayout(false);
            this.tabRegistrar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabAdicionar.ResumeLayout(false);
            this.tabAdicionar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.Button btnRemoveLivro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgLivros;
        private System.Windows.Forms.TabPage tabRegistrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtedicao;
        private System.Windows.Forms.TextBox txteditora;
        private System.Windows.Forms.TextBox txtnumeroPaginas;
        private System.Windows.Forms.TextBox txtanoPublicacao;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnConfirmaCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabAdicionar;
        private System.Windows.Forms.RichTextBox txtnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}