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
            radioButtonCorrelated.Checked= true;
            genderComboBox.SelectedIndex= 0;
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

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxBrand.Text)) 
            { 
                MessageBox.Show("Обязательно укажите бренд автомобиля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            string Brand = textBoxBrand.Text.ToString();

            string sqlSelect = "";
            if (radioButtonCorrelated.Checked)
                sqlSelect = @"SELECT Full_Name, Phone_Number
                FROM Client_Table
                WHERE EXISTS (
                  SELECT NULL
                  FROM Auto_Table
                WHERE Client_Table.Client_ID = Auto_Table.Client_ID
                AND Brand = @brand);";
            else if (radioButtonNoCorrelated.Checked)
                sqlSelect = @"SELECT Full_Name, Phone_Number, Gender
                FROM Client_Table
                WHERE Client_ID IN (
                    SELECT Client_ID
                    FROM Auto_Table
                    WHERE Brand = @brand);";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.STO_dataBaseConnectionString); 
            SqlCommand command = connection.CreateCommand(); 
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@brand", Brand);
            SqlDataAdapter adapter = new SqlDataAdapter(); 
            adapter.SelectCommand = command; 
            DataTable table = new DataTable(); 
            adapter.Fill(table); 
            dataGridViewSubquery.DataSource = table; 
            if (table.Rows.Count == 0) 
                MessageBox.Show("Нет значений!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void radioButtonDelete_Client_CheckedChanged(object sender, EventArgs e) 
        { 
            panelClient.Visible = !radioButtonDelete_Client.Checked; 
        }
        private void buttonSelectClientsClick(object sender, EventArgs e)
        {
            dataGridViewClient.DataSource = FillDataGridView("SELECT * FROM Client_Table"); 
        }
        private void buttonExecuteDML_Click(object sender, EventArgs e)
        { 
            if (radioButtonInsert_Client.Checked) 
                Insert_Client(); 
            else if 
                (radioButtonUpdate_Client.Checked) 
                UpdateClient(); 
            else if (radioButtonDelete_Client.Checked) 
                DeleteClient(); 
            else 
                MessageBox.Show("Вы не выбрали действие", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
        }
        void Insert_Client()
        {
            if ((String.IsNullOrEmpty(full_NameTextBox.Text) || (String.IsNullOrEmpty(phone_NumberTextBox.Text))))
            { 
                MessageBox.Show("Обязательно введите id Клиента, имя и номер", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return; 
            }
            long phoneNumber;
            if (!long.TryParse(phone_NumberTextBox.Text, out phoneNumber))
            {
                MessageBox.Show("Некоректное значение номера телефона Клиента!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!phone_NumberTextBox.Text.StartsWith("8"))
            {
                MessageBox.Show("Номер телефона должен начинаться с 8!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlInsert = @"INSERT INTO [dbo].[Client_Table] ([Full_Name], [Phone_Number], [Gender])
            VALUES (@FullName, @PhoneNumber, @Gender)";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.STO_dataBaseConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@FullName", full_NameTextBox.Text);
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@Gender", genderComboBox.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            { 
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }

            connection.Close();
            buttonSelectClientsClick(this, EventArgs.Empty);
        }
        void UpdateClient()
        {
            if (String.IsNullOrEmpty(textBoxClient_ID.Text))
            {
                MessageBox.Show("Обязательно укажите id Клиента, для которого будете менять данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBoxClient_ID.Text, out id))
            {
                MessageBox.Show("Некоректное значение id Клиента!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            long phoneNumber = 0;
            if ((!String.IsNullOrEmpty(phone_NumberTextBox.Text)) && (!long.TryParse(phone_NumberTextBox.Text, out phoneNumber)) 
                || !phone_NumberTextBox.Text.StartsWith("8"))
            {
                MessageBox.Show("Некоректное значение номера телефона!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlUpdate = "UPDATE [dbo].[Client_Table] SET {0} WHERE [Client_ID] = @ClientId";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.STO_dataBaseConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();

            string sqlValues = "";

            if (!String.IsNullOrEmpty(full_NameTextBox.Text))
                sqlValues += "[Full_Name] = @FullName,";
            if (!String.IsNullOrEmpty(phone_NumberTextBox.Text))
                sqlValues += "[Phone_Number] = @PhoneNumber,";
            if (!String.IsNullOrEmpty(genderComboBox.Text))
                sqlValues += "[Gender] = @Gender,";

            sqlValues = sqlValues.TrimEnd(',');

            command.CommandText = String.Format(sqlUpdate, sqlValues);
            if (!String.IsNullOrEmpty(full_NameTextBox.Text))
                command.Parameters.AddWithValue("@FullName", full_NameTextBox.Text);
            if (!String.IsNullOrEmpty(phone_NumberTextBox.Text))
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            if (!String.IsNullOrEmpty(genderComboBox.Text))
                command.Parameters.AddWithValue("@Gender", genderComboBox.Text);

            command.Parameters.AddWithValue("@ClientId", id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonSelectClientsClick(this, EventArgs.Empty);
        }
        void DeleteClient()
        {
            if (String.IsNullOrEmpty(textBoxClient_ID.Text))
            {
                MessageBox.Show("Обязательно укажите id Клиента данные которого необходимо удалить", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(textBoxClient_ID.Text, out id))
            {
                MessageBox.Show("Некоректное значение id Клиента!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlDelete = @"DELETE FROM [dbo].[Client_Table] WHERE [Client_ID] = @ClientId";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.STO_dataBaseConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@ClientId", id);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Невозможно удалить клиента, так как он указан в таблице Auto_Table. Сначала удалите соответствующие записи из таблицы Auto_Table.",
                        "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }

            connection.Close();
            buttonSelectClientsClick(this, EventArgs.Empty);
        }

    }
}
