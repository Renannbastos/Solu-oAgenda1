using System;
using System.Windows.Forms;

namespace Agenda
{
    public partial class CadPessoas : Form
    {
        public CadPessoas()
        {
            InitializeComponent();
        }

        private void CadPessoas_Load(object sender, EventArgs e)
        {
            // Carrega dados na tabela 'Atleta'
            this.atletaTableAdapter.Fill(this.dataSet1.Atleta);
        }

        private void pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.atletaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma exclusão?", "Excluir Registro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                atletaBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
        }
    }
}
