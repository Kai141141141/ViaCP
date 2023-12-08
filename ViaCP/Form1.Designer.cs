namespace ViaCP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grbResultados = new System.Windows.Forms.GroupBox();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.dgvCEP = new System.Windows.Forms.DataGridView();
            this.btnApagarTudo = new System.Windows.Forms.Button();
            this.btnApagarSeli = new System.Windows.Forms.Button();
            this.btnSalvarCEP = new System.Windows.Forms.Button();
            this.grbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCEP)).BeginInit();
            this.SuspendLayout();
            // 
            // txbBuscar
            // 
            this.txbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscar.Location = new System.Drawing.Point(51, 86);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(167, 22);
            this.txbBuscar.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("News701 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(275, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(183, 23);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Buscador de CEP";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(-3, 84);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(48, 20);
            this.lblCEP.TabIndex = 2;
            this.lblCEP.Text = "CEP:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(7, 114);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(267, 27);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grbResultados
            // 
            this.grbResultados.Controls.Add(this.lblDDD);
            this.grbResultados.Controls.Add(this.lblUF);
            this.grbResultados.Controls.Add(this.lblLocalidade);
            this.grbResultados.Controls.Add(this.lblBairro);
            this.grbResultados.Controls.Add(this.lblComplemento);
            this.grbResultados.Controls.Add(this.lblLogradouro);
            this.grbResultados.Font = new System.Drawing.Font("Schadow BT", 9.75F);
            this.grbResultados.Location = new System.Drawing.Point(12, 147);
            this.grbResultados.Name = "grbResultados";
            this.grbResultados.Size = new System.Drawing.Size(262, 197);
            this.grbResultados.TabIndex = 4;
            this.grbResultados.TabStop = false;
            this.grbResultados.Text = "Resultado";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Font = new System.Drawing.Font("Schadow BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDDD.Location = new System.Drawing.Point(7, 162);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(38, 16);
            this.lblDDD.TabIndex = 5;
            this.lblDDD.Text = "DDD:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Schadow BT", 9.75F);
            this.lblUF.Location = new System.Drawing.Point(7, 133);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(26, 16);
            this.lblUF.TabIndex = 4;
            this.lblUF.Text = "UF:";
            this.lblUF.Click += new System.EventHandler(this.lblUF_Click);
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Font = new System.Drawing.Font("Schadow BT", 9.75F);
            this.lblLocalidade.Location = new System.Drawing.Point(6, 104);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(72, 16);
            this.lblLocalidade.TabIndex = 3;
            this.lblLocalidade.Text = "Localidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Schadow BT", 9.75F);
            this.lblBairro.Location = new System.Drawing.Point(7, 78);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(46, 16);
            this.lblBairro.TabIndex = 2;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Schadow BT", 9.75F);
            this.lblComplemento.Location = new System.Drawing.Point(6, 46);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(87, 16);
            this.lblComplemento.TabIndex = 1;
            this.lblComplemento.Text = "Complemento:";
            this.lblComplemento.Click += new System.EventHandler(this.lblComplemento_Click);
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Schadow BT", 9.75F);
            this.lblLogradouro.Location = new System.Drawing.Point(6, 19);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(73, 16);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // dgvCEP
            // 
            this.dgvCEP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCEP.Location = new System.Drawing.Point(301, 57);
            this.dgvCEP.Name = "dgvCEP";
            this.dgvCEP.Size = new System.Drawing.Size(383, 210);
            this.dgvCEP.TabIndex = 5;
            this.dgvCEP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCEP_CellClick);
            this.dgvCEP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCEP_CellContentClick);
            // 
            // btnApagarTudo
            // 
            this.btnApagarTudo.BackColor = System.Drawing.Color.White;
            this.btnApagarTudo.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarTudo.Location = new System.Drawing.Point(499, 280);
            this.btnApagarTudo.Name = "btnApagarTudo";
            this.btnApagarTudo.Size = new System.Drawing.Size(185, 43);
            this.btnApagarTudo.TabIndex = 6;
            this.btnApagarTudo.Text = "APAGAR TUDO";
            this.btnApagarTudo.UseVisualStyleBackColor = false;
            this.btnApagarTudo.Click += new System.EventHandler(this.btnApagarTudo_Click);
            // 
            // btnApagarSeli
            // 
            this.btnApagarSeli.BackColor = System.Drawing.Color.Snow;
            this.btnApagarSeli.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarSeli.Location = new System.Drawing.Point(301, 280);
            this.btnApagarSeli.Name = "btnApagarSeli";
            this.btnApagarSeli.Size = new System.Drawing.Size(164, 43);
            this.btnApagarSeli.TabIndex = 7;
            this.btnApagarSeli.Text = "APAGAR SELECIONADO";
            this.btnApagarSeli.UseVisualStyleBackColor = false;
            this.btnApagarSeli.Click += new System.EventHandler(this.btnApagarSeli_Click);
            // 
            // btnSalvarCEP
            // 
            this.btnSalvarCEP.BackColor = System.Drawing.Color.LightYellow;
            this.btnSalvarCEP.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCEP.Location = new System.Drawing.Point(7, 350);
            this.btnSalvarCEP.Name = "btnSalvarCEP";
            this.btnSalvarCEP.Size = new System.Drawing.Size(267, 23);
            this.btnSalvarCEP.TabIndex = 8;
            this.btnSalvarCEP.Text = "SALVAR CEP";
            this.btnSalvarCEP.UseVisualStyleBackColor = false;
            this.btnSalvarCEP.Click += new System.EventHandler(this.btnSalvarCEP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 432);
            this.Controls.Add(this.btnSalvarCEP);
            this.Controls.Add(this.btnApagarSeli);
            this.Controls.Add(this.btnApagarTudo);
            this.Controls.Add(this.dgvCEP);
            this.Controls.Add(this.grbResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbBuscar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbResultados.ResumeLayout(false);
            this.grbResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grbResultados;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.DataGridView dgvCEP;
        private System.Windows.Forms.Button btnApagarTudo;
        private System.Windows.Forms.Button btnApagarSeli;
        private System.Windows.Forms.Button btnSalvarCEP;
    }
}

