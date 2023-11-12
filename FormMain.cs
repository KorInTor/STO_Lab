using STO_Lab.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STO_Lab
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FormSQL.fs.ShowForm();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) 
        { 
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes; 
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,КСУП,Пряхин Д.С.,группа 571-1 ,2023", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployeesList.fe.ShowForm();
        }

        private void обслуженныеАвтоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPartsList.fp.ShowForm();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientsList.fс.ShowForm();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrderList.fo.ShowForm();
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL.fs.ShowForm();
        }
    }
}
