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
    public partial class FormEmployeesList : Form
    {
        private static FormEmployeesList f;

        public static FormEmployeesList fe 
        { 
            get 
            { 
                if (f == null || f.IsDisposed) 
                    f = new FormEmployeesList(); 
                return f; 
            } 
        }

        public void ShowForm() 
        { 
            Show(); 
            Activate(); 
        }

        public FormEmployeesList()
        {
            InitializeComponent();
        }

        private void employee_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTODataSet);

        }

        private void FormEmployeesList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTODataSet.Employee_Table". При необходимости она может быть перемещена или удалена.
            this.employee_TableTableAdapter.Fill(this.sTODataSet.Employee_Table);

        }

        string fileImage = "";
        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото"; if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName; 
                try
                {

                    photoPictureBox.Image = new Bitmap(openFileDialogPhoto.FileName);
                }
                catch 
                { 
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }

            }
            else fileImage = "";
        }
    }
}
