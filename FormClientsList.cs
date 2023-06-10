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

        string GetSelectedFieldName() 
        { 
            return client_TableDataGridView.Columns[client_TableDataGridView.CurrentCell.ColumnIndex].DataPropertyName; 
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

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            {
                if (toolStripTextBoxFind.Text == "") 
                { 
                    MessageBox.Show("Вы ничего не задали", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    return; 
                }

                int indexPos;

                try 
                { 
                    indexPos = client_TableBindingSource.Find(GetSelectedFieldName(), toolStripTextBoxFind.Text); 
                } 
                catch (Exception err) 
                { 
                    MessageBox.Show("Ошибка поиска \n" + err.Message); 
                    return; 
                }

                if (indexPos > -1)
                    client_TableBindingSource.Position = indexPos; 
                else 
                { 
                    MessageBox.Show("Таких сотрудников нет", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    client_TableBindingSource.Position = 0; 
                }
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBoxFind.Checked)
                {
                    if (toolStripTextBoxFind.Text == "") MessageBox.Show("Вы ничего не задали", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else try
                        {
                            client_TableBindingSource.Filter = GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";

                        }
                        catch (Exception err) { MessageBox.Show("Ошибка фильтрации \n" + err.Message); }
                }
                else client_TableBindingSource.Filter = "";

                if (client_TableBindingSource.Count == 0)
                {
                    MessageBox.Show("Нет таких");
                    client_TableBindingSource.Filter = ""; checkBoxFind.Checked = false;
                }
            }
        }
    }
}
