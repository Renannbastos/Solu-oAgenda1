using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void MDI_Menu_Load(object sender, EventArgs e)
        {

        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadPessoas objCadPes = new CadPessoas();
            objCadPes.MdiParent = this;
            objCadPes.Show();
        }

        private void pessoasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaPessoas objConsultaPessoas = new frmConsultaPessoas();
            objConsultaPessoas.MdiParent = this;
            objConsultaPessoas.Show();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
