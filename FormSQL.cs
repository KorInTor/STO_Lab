using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace STO_Lab
{
    public partial class FormSQL : Form
    {
        private static FormSQL f;

        public static FormSQL fs
        {
            get
            {
                if (f == null || f.IsDisposed)
                    f = new FormSQL();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        public FormSQL()
        {
            InitializeComponent();
            SelectedGenderComboBox.SelectedIndex= 0;
        }
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источником данных
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.STO_dataBaseConnectionString);

            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();

            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;

            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();

            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;

            //Создаем объект table для последующего отображения результата запроса
            DataTable table = new DataTable();

            //заполним набор данных результатом запроса
            adapter.Fill(table);

            return table;
        }

        private void radioButtonEmployee_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Employee_Table");
        }

        private void radioButtonClient_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT Client_Table.Full_Name, Auto_Table.Brand, Auto_Table.Model" +
                " FROM Client_Table JOIN Auto_Table ON Client_Table.Client_ID = Auto_Table.Client_ID;");
        }

        private void radioButtonOrder_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Order_Table WHERE Status = 'false'");
        }

        private void Select_Button_Click(object sender, EventArgs e)
        {
            bool showOnlyCompletedOrders = false;

            if (CompletedOrderCheckBox.Checked) 
            {
                showOnlyCompletedOrders = true;
            }

            string SelectedGender = SelectedGenderComboBox.SelectedItem.ToString();

            string sqlSelect = @"SELECT Employee_Table.Full_Name, Employee_Table.Gender, COUNT(*) as Order_Count
            FROM Employee_Table
            JOIN Order_Employee_Rel_Table
            ON Employee_Table.ID = Order_Employee_Rel_Table.Employee_ID
            JOIN Order_Table
            ON Order_Employee_Rel_Table.Order_ID = Order_Table.Order_ID
            WHERE Employee_Table.Gender = @SelectedGender AND (@ShowOnlyCompletedOrders = 0 OR Order_Table.Status = 'true')
            GROUP BY Employee_Table.Full_Name, Employee_Table.Gender";
            //HAVING COUNT(*) > 1
            //ORDER BY COUNT(*) DESC;";

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.STO_dataBaseConnectionString);
            SqlCommand command = connection.CreateCommand();

            int OrderCount = 0;

            if (OrderCountIfCheckBox.Checked)
            {
                try
                {
                    OrderCount = int.Parse(OrderCountTextBox.Text);
                    if (OrderCount < 0)
                        throw new FormatException();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Количество заказов должно быть целочисленным и положительным числом", "Ошибка");
                }
                finally
                {
                    sqlSelect += " HAVING COUNT(*) > @OrderCount";
                }
            }
            if (OrderByCheckBox.Checked)
            {
                string orderByDirection = OrderByAscendingRadioButton.Checked ? "ASC" : "DESC";
                sqlSelect += $" ORDER BY COUNT(*) {orderByDirection}";
            }
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@SelectedGender", SelectedGender);
            command.Parameters.AddWithValue("@ShowOnlyCompletedOrders", showOnlyCompletedOrders ? 1 : 0);
            if (OrderCountIfCheckBox.Checked)
                command.Parameters.AddWithValue("@OrderCount", OrderCount);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView.DataSource = table;
        }

        private void OrderByCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OrderByCheckBox.Checked)
            {
                OrderByAscendingRadioButton.Visible= true;
                OrderByDescendingRadioButton.Visible= true;
                OrderByAscendingRadioButton.Checked= true;
            }
            else
            {
                OrderByAscendingRadioButton.Visible = false;
                OrderByDescendingRadioButton.Visible = false;
            }
        }
    }
}
