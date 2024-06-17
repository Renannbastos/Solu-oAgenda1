using System;
using System.Globalization;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmConsultaPessoas : Form
    {
        public frmConsultaPessoas()
        {
            InitializeComponent();
        }

        private void frmConsultaPessoas_Load(object sender, EventArgs e)
        {
            // Carrega dados na tabela 'Atleta'
            this.atletaTableAdapter.Fill(this.dataSet1.Atleta);
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            string vColuna = cmbColuna.Text.Trim();
            string vProcurar = cmbProcurar.Text.Trim();
            string vTexto = txtPesquisa.Text.Trim();
            string vFiltro = "";

            // Construir a expressão de filtro baseada na seleção do usuário
            if (!string.IsNullOrEmpty(vColuna) && !string.IsNullOrEmpty(vProcurar))
            {
                if (vProcurar == "Que começa com")
                {
                    vFiltro = vColuna + " LIKE '" + vTexto + "%'";
                }
                else if (vProcurar == "Que contém")
                {
                    vFiltro = vColuna + " LIKE '%" + vTexto + "%'";
                }
                else if (vProcurar == "Igual")
                {
                    // Verifica se a coluna é numérica (Salário) ou data (Data de Nascimento)
                    if (cmbColuna.Text == "SALÁRIO")
                    {
                        decimal valor;
                        if (decimal.TryParse(vTexto, out valor))
                        {
                            vFiltro = vColuna + " = " + vTexto;
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um valor numérico válido para 'Igual a Salário'.");
                            return;
                        }
                    }
                    else if (cmbColuna.Text == "DATA_NASCIMENTO")
                    {
                        DateTime data;
                        if (DateTime.TryParse(vTexto, out data))
                        {
                            vFiltro = vColuna + " = #" + data.ToString("MM/dd/yyyy") + "#";
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira uma data válida para 'Igual a Data de Nascimento'.");
                            return;
                        }
                    }
                    else
                    {
                        vFiltro = vColuna + " = '" + vTexto + "'";
                    }
                }
                else if (vProcurar == "Que termina com")
                {
                    vFiltro = vColuna + " LIKE '%" + vTexto + "'";
                }
                else if (vProcurar == "Entre")
                {
                    string[] valores = vTexto.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (valores.Length != 2)
                    {
                        MessageBox.Show("Por favor, insira dois valores separados por vírgula para 'Entre'.");
                        return;
                    }

                    // Verifica se a coluna é numérica (Salário) ou data (Data de Nascimento)
                    if (cmbColuna.Text == "SALÁRIO")
                    {
                        decimal valor1, valor2;
                        if (decimal.TryParse(valores[0], out valor1) && decimal.TryParse(valores[1], out valor2))
                        {
                            vFiltro = string.Format(CultureInfo.InvariantCulture, "{0} >= {1} AND {0} <= {2}", vColuna, valor1, valor2);
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira valores numéricos válidos separados por vírgula para 'Entre Salário'.");
                            return;
                        }
                    }
                    else if (cmbColuna.Text == "DATA_NASCIMENTO")
                    {
                        DateTime data1, data2;
                        if (DateTime.TryParse(valores[0], out data1) && DateTime.TryParse(valores[1], out data2))
                        {
                            vFiltro = string.Format(CultureInfo.InvariantCulture, "{0} >= #{1}# AND {0} <= #{2}#", vColuna, data1.ToString("MM/dd/yyyy"), data2.ToString("MM/dd/yyyy"));
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira datas válidas separadas por vírgula para 'Entre Data de Nascimento'.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("A opção 'Entre' só pode ser utilizada com colunas numéricas (Salário) ou de data (Data de Nascimento).");
                        return;
                    }
                }
                else if (vProcurar == "Todos")
                {
                    vFiltro = ""; // Remove qualquer filtro existente
                }
            }

            // Aplicar o filtro ao BindingSource
            atletaBindingSource.Filter = vFiltro;
        }

        private void cmbColuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Atualizar itens do combo de acordo com a coluna selecionada
            if (cmbColuna.Text == "NOME" || cmbColuna.Text == "ESPORTE" || cmbColuna.Text == "NACIONALIDADE")
            {
                cmbProcurar.Items.Clear();
                cmbProcurar.Items.Add("Que começa com");
                cmbProcurar.Items.Add("Que contém");
                cmbProcurar.Items.Add("Todos");
                cmbProcurar.Items.Add("Igual");
                cmbProcurar.Items.Add("Que termina com");
                textBox4.Enabled = false;
            }
            else if (cmbColuna.Text == "SALÁRIO" || cmbColuna.Text == "DATA_NASCIMENTO")
            {
                cmbProcurar.Items.Clear();
                cmbProcurar.Items.Add("Todos");
                cmbProcurar.Items.Add("Igual");
                cmbProcurar.Items.Add("Entre");
                textBox4.Enabled = true;
            }
            else
            {
                cmbProcurar.Items.Clear();
                cmbProcurar.Items.Add("Todos");
                cmbProcurar.Items.Add("Entre");
                cmbProcurar.Items.Add("Igual");
                textBox4.Enabled = true;
            }
        }

        private void cmbProcurar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilitar textBox4 apenas se "Igual" ou "Entre" estiver selecionado e a coluna for SALÁRIO ou DATA_NASCIMENTO
            if ((cmbProcurar.Text == "Entre") && (cmbColuna.Text == "SALÁRIO" || cmbColuna.Text == "DATA_NASCIMENTO"))
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Lógica adicional para manipulação de texto no textBox4
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // Lógica adicional para manipulação de texto na pesquisa
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica adicional para manipulação de cliques nas células do DataGridView
        }
    }
}
