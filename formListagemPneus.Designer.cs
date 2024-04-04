namespace Controle_de_Pneus
{
    partial class formListagemPneus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formListagemPneus));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarFogo = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboLocal = new System.Windows.Forms.ComboBox();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.dgvPneusList = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIncluirSeq = new System.Windows.Forms.Button();
            this.btnNovoPneu = new System.Windows.Forms.Button();
            this.btnBuscarFogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPneusList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPneusList);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 554);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 184);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIncluirSeq);
            this.panel2.Controls.Add(this.btnNovoPneu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 91);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscarFogo);
            this.groupBox1.Controls.Add(this.txtBuscarFogo);
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.cboLocal);
            this.groupBox1.Controls.Add(this.cboModelo);
            this.groupBox1.Controls.Add(this.cboMarca);
            this.groupBox1.Location = new System.Drawing.Point(16, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca de pneus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Local:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marca:";
            // 
            // txtBuscarFogo
            // 
            this.txtBuscarFogo.Location = new System.Drawing.Point(685, 42);
            this.txtBuscarFogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarFogo.Name = "txtBuscarFogo";
            this.txtBuscarFogo.Size = new System.Drawing.Size(232, 22);
            this.txtBuscarFogo.TabIndex = 4;
            this.txtBuscarFogo.Text = "Procurar número de fogo...";
            this.txtBuscarFogo.Enter += new System.EventHandler(this.txtBuscarFogo_Enter);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(516, 42);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(160, 24);
            this.cboStatus.TabIndex = 3;
            this.cboStatus.SelectionChangeCommitted += new System.EventHandler(this.cboStatus_SelectionChangeCommitted);
            // 
            // cboLocal
            // 
            this.cboLocal.FormattingEnabled = true;
            this.cboLocal.Location = new System.Drawing.Point(347, 42);
            this.cboLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLocal.Name = "cboLocal";
            this.cboLocal.Size = new System.Drawing.Size(160, 24);
            this.cboLocal.TabIndex = 2;
            this.cboLocal.SelectionChangeCommitted += new System.EventHandler(this.cboLocal_SelectionChangeCommitted);
            // 
            // cboModelo
            // 
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(177, 42);
            this.cboModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(160, 24);
            this.cboModelo.TabIndex = 1;
            this.cboModelo.SelectionChangeCommitted += new System.EventHandler(this.cboModelo_SelectionChangeCommitted);
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Items.AddRange(new object[] {
            "<TODOS>"});
            this.cboMarca.Location = new System.Drawing.Point(8, 42);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(160, 24);
            this.cboMarca.TabIndex = 0;
            this.cboMarca.SelectionChangeCommitted += new System.EventHandler(this.cboMarca_SelectionChangeCommitted);
            // 
            // dgvPneusList
            // 
            this.dgvPneusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPneusList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6});
            this.dgvPneusList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPneusList.Location = new System.Drawing.Point(0, 0);
            this.dgvPneusList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPneusList.Name = "dgvPneusList";
            this.dgvPneusList.RowHeadersWidth = 51;
            this.dgvPneusList.Size = new System.Drawing.Size(1067, 365);
            this.dgvPneusList.TabIndex = 0;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Selecionar";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NumFogo";
            this.Column1.HeaderText = "Fogo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DescricaoModelo";
            this.Column2.HeaderText = "Modelo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DescricaoMarca";
            this.Column3.HeaderText = "Marca";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StatusPneu";
            this.Column4.HeaderText = "Status";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "KmPneu";
            this.Column5.HeaderText = "Quilometragem";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Descricao";
            this.Column7.HeaderText = "Local";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DataEntrada";
            this.Column6.HeaderText = "Data de Entrada";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // btnIncluirSeq
            // 
            this.btnIncluirSeq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirSeq.Image = global::Controle_de_Pneus.Properties.Resources._11230177_copy_clipboard_icon20px;
            this.btnIncluirSeq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirSeq.Location = new System.Drawing.Point(104, 3);
            this.btnIncluirSeq.Name = "btnIncluirSeq";
            this.btnIncluirSeq.Size = new System.Drawing.Size(123, 85);
            this.btnIncluirSeq.TabIndex = 1;
            this.btnIncluirSeq.Text = "Incluir Sequência";
            this.btnIncluirSeq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluirSeq.UseVisualStyleBackColor = true;
            // 
            // btnNovoPneu
            // 
            this.btnNovoPneu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoPneu.Image = global::Controle_de_Pneus.Properties.Resources._11230174_documet_add_file_icon20px;
            this.btnNovoPneu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoPneu.Location = new System.Drawing.Point(12, 3);
            this.btnNovoPneu.Name = "btnNovoPneu";
            this.btnNovoPneu.Size = new System.Drawing.Size(86, 85);
            this.btnNovoPneu.TabIndex = 0;
            this.btnNovoPneu.Text = "Incluir Pneu";
            this.btnNovoPneu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoPneu.UseVisualStyleBackColor = true;
            this.btnNovoPneu.Click += new System.EventHandler(this.btnNovoPneu_Click);
            // 
            // btnBuscarFogo
            // 
            this.btnBuscarFogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFogo.Image = global::Controle_de_Pneus.Properties.Resources._3669134_find_in_page_ic_icon;
            this.btnBuscarFogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarFogo.Location = new System.Drawing.Point(927, 39);
            this.btnBuscarFogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarFogo.Name = "btnBuscarFogo";
            this.btnBuscarFogo.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarFogo.TabIndex = 5;
            this.btnBuscarFogo.Text = "&Buscar";
            this.btnBuscarFogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarFogo.UseVisualStyleBackColor = true;
            this.btnBuscarFogo.Click += new System.EventHandler(this.btnBuscarFogo_Click);
            // 
            // formListagemPneus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formListagemPneus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pneus";
            this.Load += new System.EventHandler(this.formListagemPneus_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPneusList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPneusList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarFogo;
        private System.Windows.Forms.TextBox txtBuscarFogo;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboLocal;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnNovoPneu;
        private System.Windows.Forms.Button btnIncluirSeq;
    }
}