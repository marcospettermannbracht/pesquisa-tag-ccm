
namespace PesquisaTagCCM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cmbTipoPesq = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbImagem = new System.Windows.Forms.Label();
            this.ccmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccmDataGridViewTextBoxColumn,
            this.colunaDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.motoresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.motorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 26);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(802, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(242, 3);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyUp);
            // 
            // cmbTipoPesq
            // 
            this.cmbTipoPesq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPesq.FormattingEnabled = true;
            this.cmbTipoPesq.Items.AddRange(new object[] {
            "CCM",
            "TAG"});
            this.cmbTipoPesq.Location = new System.Drawing.Point(115, 3);
            this.cmbTipoPesq.Name = "cmbTipoPesq";
            this.cmbTipoPesq.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPesq.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar por:";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(348, 2);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 4;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(429, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "2 cliques na linha para abrir o PDF";
            // 
            // lbImagem
            // 
            this.lbImagem.Image = ((System.Drawing.Image)(resources.GetObject("lbImagem.Image")));
            this.lbImagem.Location = new System.Drawing.Point(-2, 214);
            this.lbImagem.Name = "lbImagem";
            this.lbImagem.Size = new System.Drawing.Size(805, 363);
            this.lbImagem.TabIndex = 6;
            // 
            // ccmDataGridViewTextBoxColumn
            // 
            this.ccmDataGridViewTextBoxColumn.DataPropertyName = "ccm";
            this.ccmDataGridViewTextBoxColumn.HeaderText = "CCM";
            this.ccmDataGridViewTextBoxColumn.Name = "ccmDataGridViewTextBoxColumn";
            this.ccmDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccmDataGridViewTextBoxColumn.Width = 150;
            // 
            // colunaDataGridViewTextBoxColumn
            // 
            this.colunaDataGridViewTextBoxColumn.DataPropertyName = "coluna";
            this.colunaDataGridViewTextBoxColumn.HeaderText = "Coluna";
            this.colunaDataGridViewTextBoxColumn.Name = "colunaDataGridViewTextBoxColumn";
            this.colunaDataGridViewTextBoxColumn.ReadOnly = true;
            this.colunaDataGridViewTextBoxColumn.Width = 150;
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.ReadOnly = true;
            this.tagDataGridViewTextBoxColumn.Width = 150;
            // 
            // motoresDataGridViewTextBoxColumn
            // 
            this.motoresDataGridViewTextBoxColumn.DataPropertyName = "motores";
            this.motoresDataGridViewTextBoxColumn.HeaderText = "Motores";
            this.motoresDataGridViewTextBoxColumn.Name = "motoresDataGridViewTextBoxColumn";
            this.motoresDataGridViewTextBoxColumn.ReadOnly = true;
            this.motoresDataGridViewTextBoxColumn.Width = 275;
            // 
            // motorBindingSource
            // 
            this.motorBindingSource.DataSource = typeof(PesquisaTagCCM.Motor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 576);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbImagem);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoPesq);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Pesquisa Tag CCM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource motorBindingSource;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ComboBox cmbTipoPesq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lbImagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}

