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
    public partial class FormOrderList : Form
    {
        private static FormOrderList f;

        public static FormOrderList fo
        {
            get
            {
                if (f == null || f.IsDisposed)
                    f = new FormOrderList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        public FormOrderList()
        {
            InitializeComponent();
        }

        private void order_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try 
            { 
                this.Validate();
                this.order_TableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sTODataSet);
            }
            catch (Exception err) 
            { 
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void order_Employee_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.order_TableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sTODataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTODataSet.Employee_Table". При необходимости она может быть перемещена или удалена.
            this.employee_TableTableAdapter.Fill(this.sTODataSet.Employee_Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTODataSet.Auto_Table". При необходимости она может быть перемещена или удалена.
            this.auto_TableTableAdapter.Fill(this.sTODataSet.Auto_Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTODataSet.Auto_Table". При необходимости она может быть перемещена или удалена.
            this.auto_TableTableAdapter.Fill(this.sTODataSet.Auto_Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTODataSet.Order_Employee_Rel_Table". При необходимости она может быть перемещена или удалена.
            this.order_Employee_Rel_TableTableAdapter.Fill(this.sTODataSet.Order_Employee_Rel_Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTODataSet.Order_Table". При необходимости она может быть перемещена или удалена.
            this.order_TableTableAdapter.Fill(this.sTODataSet.Order_Table);

        }
    }
}
