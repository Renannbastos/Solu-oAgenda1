
namespace Agenda
{
    partial class frmConsultaPessoas
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
            this.components = new System.ComponentModel.Container();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cmbColuna = new System.Windows.Forms.ComboBox();
            this.cmbProcurar = new System.Windows.Forms.ComboBox();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Agenda.DataSet1();
            this.pessoaTableAdapter = new Agenda.DataSet1TableAdapters.PessoaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.atletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atletaTableAdapter = new Agenda.DataSet1TableAdapters.AtletaTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSPORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nACIONALIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALÁRIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATANASCIMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(524, 26);
            this.btnfiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(50, 43);
            this.btnfiltrar.TabIndex = 1;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "Pessoa";
            this.pessoaBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(270, 38);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(123, 20);
            this.txtPesquisa.TabIndex = 4;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(397, 38);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cmbColuna
            // 
            this.cmbColuna.Items.AddRange(new object[] {
            "ID",
            "NOME",
            "ESPORTE",
            "NACIONALIDADE",
            "SALÁRIO",
            "DATA_NASCIMENTO"});
            this.cmbColuna.Location = new System.Drawing.Point(17, 37);
            this.cmbColuna.Name = "cmbColuna";
            this.cmbColuna.Size = new System.Drawing.Size(121, 21);
            this.cmbColuna.TabIndex = 6;
            this.cmbColuna.SelectedIndexChanged += new System.EventHandler(this.cmbColuna_SelectedIndexChanged);
            // 
            // cmbProcurar
            // 
            this.cmbProcurar.FormattingEnabled = true;
            this.cmbProcurar.Items.AddRange(new object[] {
            "Que começa com",
            "Que contém",
            "Que termina com",
            "Igual a ",
            "Todos"});
            this.cmbProcurar.Location = new System.Drawing.Point(144, 37);
            this.cmbProcurar.Name = "cmbProcurar";
            this.cmbProcurar.Size = new System.Drawing.Size(121, 21);
            this.cmbProcurar.TabIndex = 7;
            this.cmbProcurar.SelectedIndexChanged += new System.EventHandler(this.cmbProcurar_SelectedIndexChanged);
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.eSPORTEDataGridViewTextBoxColumn,
            this.nACIONALIDADEDataGridViewTextBoxColumn,
            this.sALÁRIODataGridViewTextBoxColumn,
            this.dATANASCIMENTODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.atletaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // atletaBindingSource
            // 
            this.atletaBindingSource.DataMember = "Atleta";
            this.atletaBindingSource.DataSource = this.dataSet1;
            // 
            // atletaTableAdapter
            // 
            this.atletaTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            // 
            // eSPORTEDataGridViewTextBoxColumn
            // 
            this.eSPORTEDataGridViewTextBoxColumn.DataPropertyName = "ESPORTE";
            this.eSPORTEDataGridViewTextBoxColumn.HeaderText = "ESPORTE";
            this.eSPORTEDataGridViewTextBoxColumn.Name = "eSPORTEDataGridViewTextBoxColumn";
            // 
            // nACIONALIDADEDataGridViewTextBoxColumn
            // 
            this.nACIONALIDADEDataGridViewTextBoxColumn.DataPropertyName = "NACIONALIDADE";
            this.nACIONALIDADEDataGridViewTextBoxColumn.HeaderText = "NACIONALIDADE";
            this.nACIONALIDADEDataGridViewTextBoxColumn.Name = "nACIONALIDADEDataGridViewTextBoxColumn";
            // 
            // sALÁRIODataGridViewTextBoxColumn
            // 
            this.sALÁRIODataGridViewTextBoxColumn.DataPropertyName = "SALÁRIO";
            this.sALÁRIODataGridViewTextBoxColumn.HeaderText = "SALÁRIO";
            this.sALÁRIODataGridViewTextBoxColumn.Name = "sALÁRIODataGridViewTextBoxColumn";
            // 
            // dATANASCIMENTODataGridViewTextBoxColumn
            // 
            this.dATANASCIMENTODataGridViewTextBoxColumn.DataPropertyName = "DATA_NASCIMENTO";
            this.dATANASCIMENTODataGridViewTextBoxColumn.HeaderText = "DATA_NASCIMENTO";
            this.dATANASCIMENTODataGridViewTextBoxColumn.Name = "dATANASCIMENTODataGridViewTextBoxColumn";
            // 
            // frmConsultaPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 332);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbProcurar);
            this.Controls.Add(this.cmbColuna);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnfiltrar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmConsultaPessoas";
            this.Text = "frmConsultaPessoas";
            this.Load += new System.EventHandler(this.frmConsultaPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private DataSet1TableAdapters.PessoaTableAdapter pessoaTableAdapter;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cmbColuna;
        private System.Windows.Forms.ComboBox cmbProcurar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource atletaBindingSource;
        private DataSet1TableAdapters.AtletaTableAdapter atletaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPORTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nACIONALIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALÁRIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATANASCIMENTODataGridViewTextBoxColumn;
    }
}