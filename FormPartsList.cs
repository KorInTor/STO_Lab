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
    public partial class FormPartsList : Form
    {
        private static FormPartsList f;

        public static FormPartsList fp 
        {
            get
            { 
                if (f == null || f.IsDisposed) 
                    f = new FormPartsList(); 
                return f; 
            } 
        }

        public void ShowForm() 
        { 
            Show(); 
            Activate(); 
        }

        public FormPartsList()
        {
            InitializeComponent();
        }

        private void parts_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.parts_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTODataSet);

        }

        private void parts_TableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.parts_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTODataSet);

        }

        private void parts_TableBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.parts_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTODataSet);

        }

        private void FormPartsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTODataSet.Parts_Table". При необходимости она может быть перемещена или удалена.
            this.parts_TableTableAdapter.Fill(this.sTODataSet.Parts_Table);

        }
    }
}
