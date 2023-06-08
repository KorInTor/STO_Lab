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
    public partial class FormClientsList : Form
    {
        private static FormClientsList f;

        public static FormClientsList fс 
        { 
            get 
            { 
                if (f == null || f.IsDisposed) 
                    f = new FormClientsList(); 
                return f; 
            } 
        }

        public void ShowForm() 
        { 
            Show(); 
            Activate(); 
        }

        private void client_DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((client_TableDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnPol"].Value == null) 
                || (client_TableDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnPol"].Value.ToString() == "")) 
                e.CellStyle.BackColor = Color.LightGreen;
            else
            {
                if (client_TableDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnPol"].Value.ToString() == "Male  ") 
                    e.CellStyle.BackColor = Color.SkyBlue; 
                else 
                    e.CellStyle.BackColor = Color.Pink;

            }
        }

        public FormClientsList()
        {
            InitializeComponent();
        }

        private void client_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.client_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTODataSet);

        }

        private void FormClientsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTODataSet.Client_Table". При необходимости она может быть перемещена или удалена.
            this.client_TableTableAdapter.Fill(this.sTODataSet.Client_Table);
        }

        private void client_TableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Get the value of the cell where the error occurred
            var cellValue = client_TableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            // Log the value of the cell
            Console.WriteLine("Error occurred in cell with value: " + cellValue);

            e.Cancel = true;
        }
    }
}
