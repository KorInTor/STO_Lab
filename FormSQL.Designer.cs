namespace STO_Lab
{
    partial class FormSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label full_NameLabel;
            System.Windows.Forms.Label phone_NumberLabel;
            System.Windows.Forms.Label genderLabel;
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPageExamples = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonClient = new System.Windows.Forms.RadioButton();
            this.radioButtonEmployee = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SelectGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderByDescendingRadioButton = new System.Windows.Forms.RadioButton();
            this.OrderByAscendingRadioButton = new System.Windows.Forms.RadioButton();
            this.OrderByCheckBox = new System.Windows.Forms.CheckBox();
            this.OrderCountIfCheckBox = new System.Windows.Forms.CheckBox();
            this.OrderCountTextBox = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.SelectedGenderComboBox = new System.Windows.Forms.ComboBox();
            this.CompletedOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.Select_Button = new System.Windows.Forms.Button();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.SubqueryGroupBox = new System.Windows.Forms.GroupBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.panelClient = new System.Windows.Forms.Panel();
            this.buttonSelectClient = new System.Windows.Forms.Button();
            this.full_NameTextBox = new System.Windows.Forms.TextBox();
            this.phone_NumberTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.textBoxClient_ID = new System.Windows.Forms.TextBox();
            this.labelClient_ID = new System.Windows.Forms.Label();
            this.radioButtonDelete_Client = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate_Client = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert_Client = new System.Windows.Forms.RadioButton();
            full_NameLabel = new System.Windows.Forms.Label();
            phone_NumberLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            this.tabControlSQL.SuspendLayout();
            this.tabPageExamples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SelectGroupBox.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.SubqueryGroupBox.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.panelClient.SuspendLayout();
            this.groupBoxDML.SuspendLayout();
            this.SuspendLayout();
            // 
            // full_NameLabel
            // 
            full_NameLabel.AutoSize = true;
            full_NameLabel.Location = new System.Drawing.Point(16, 16);
            full_NameLabel.Name = "full_NameLabel";
            full_NameLabel.Size = new System.Drawing.Size(57, 13);
            full_NameLabel.TabIndex = 2;
            full_NameLabel.Text = "Full Name:";
            // 
            // phone_NumberLabel
            // 
            phone_NumberLabel.AutoSize = true;
            phone_NumberLabel.Location = new System.Drawing.Point(16, 42);
            phone_NumberLabel.Name = "phone_NumberLabel";
            phone_NumberLabel.Size = new System.Drawing.Size(81, 13);
            phone_NumberLabel.TabIndex = 4;
            phone_NumberLabel.Text = "Phone Number:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(16, 68);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "Gender:";
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPageExamples);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(747, 507);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPageExamples
            // 
            this.tabPageExamples.Controls.Add(this.dataGridViewSelect);
            this.tabPageExamples.Controls.Add(this.groupBoxSelect);
            this.tabPageExamples.Location = new System.Drawing.Point(4, 22);
            this.tabPageExamples.Name = "tabPageExamples";
            this.tabPageExamples.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExamples.Size = new System.Drawing.Size(739, 481);
            this.tabPageExamples.TabIndex = 0;
            this.tabPageExamples.Text = "Examples";
            this.tabPageExamples.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 94);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(733, 384);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonOrder);
            this.groupBoxSelect.Controls.Add(this.radioButtonClient);
            this.groupBoxSelect.Controls.Add(this.radioButtonEmployee);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(733, 91);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Data query";
            // 
            // radioButtonOrder
            // 
            this.radioButtonOrder.AutoSize = true;
            this.radioButtonOrder.Location = new System.Drawing.Point(169, 37);
            this.radioButtonOrder.Name = "radioButtonOrder";
            this.radioButtonOrder.Size = new System.Drawing.Size(56, 17);
            this.radioButtonOrder.TabIndex = 2;
            this.radioButtonOrder.TabStop = true;
            this.radioButtonOrder.Text = "Orders";
            this.radioButtonOrder.UseVisualStyleBackColor = true;
            this.radioButtonOrder.CheckedChanged += new System.EventHandler(this.radioButtonOrder_CheckedChanged);
            // 
            // radioButtonClient
            // 
            this.radioButtonClient.AutoSize = true;
            this.radioButtonClient.Location = new System.Drawing.Point(98, 37);
            this.radioButtonClient.Name = "radioButtonClient";
            this.radioButtonClient.Size = new System.Drawing.Size(56, 17);
            this.radioButtonClient.TabIndex = 1;
            this.radioButtonClient.TabStop = true;
            this.radioButtonClient.Text = "Clients";
            this.radioButtonClient.UseVisualStyleBackColor = true;
            this.radioButtonClient.CheckedChanged += new System.EventHandler(this.radioButtonClient_CheckedChanged);
            // 
            // radioButtonEmployee
            // 
            this.radioButtonEmployee.AutoSize = true;
            this.radioButtonEmployee.Location = new System.Drawing.Point(6, 37);
            this.radioButtonEmployee.Name = "radioButtonEmployee";
            this.radioButtonEmployee.Size = new System.Drawing.Size(76, 17);
            this.radioButtonEmployee.TabIndex = 0;
            this.radioButtonEmployee.TabStop = true;
            this.radioButtonEmployee.Text = "Employees";
            this.radioButtonEmployee.UseVisualStyleBackColor = true;
            this.radioButtonEmployee.CheckedChanged += new System.EventHandler(this.radioButtonEmployee_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridView);
            this.tabPageSelect.Controls.Add(this.SelectGroupBox);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(739, 481);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Select";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 184);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(733, 294);
            this.dataGridView.TabIndex = 0;
            // 
            // SelectGroupBox
            // 
            this.SelectGroupBox.Controls.Add(this.OrderByDescendingRadioButton);
            this.SelectGroupBox.Controls.Add(this.OrderByAscendingRadioButton);
            this.SelectGroupBox.Controls.Add(this.OrderByCheckBox);
            this.SelectGroupBox.Controls.Add(this.OrderCountIfCheckBox);
            this.SelectGroupBox.Controls.Add(this.OrderCountTextBox);
            this.SelectGroupBox.Controls.Add(this.labelGender);
            this.SelectGroupBox.Controls.Add(this.SelectedGenderComboBox);
            this.SelectGroupBox.Controls.Add(this.CompletedOrderCheckBox);
            this.SelectGroupBox.Controls.Add(this.Select_Button);
            this.SelectGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SelectGroupBox.Name = "SelectGroupBox";
            this.SelectGroupBox.Size = new System.Drawing.Size(733, 181);
            this.SelectGroupBox.TabIndex = 3;
            this.SelectGroupBox.TabStop = false;
            this.SelectGroupBox.Text = "Employes Select";
            // 
            // OrderByDescendingRadioButton
            // 
            this.OrderByDescendingRadioButton.AutoSize = true;
            this.OrderByDescendingRadioButton.Location = new System.Drawing.Point(81, 142);
            this.OrderByDescendingRadioButton.Name = "OrderByDescendingRadioButton";
            this.OrderByDescendingRadioButton.Size = new System.Drawing.Size(82, 17);
            this.OrderByDescendingRadioButton.TabIndex = 10;
            this.OrderByDescendingRadioButton.TabStop = true;
            this.OrderByDescendingRadioButton.Text = "Descending";
            this.OrderByDescendingRadioButton.UseVisualStyleBackColor = true;
            this.OrderByDescendingRadioButton.Visible = false;
            // 
            // OrderByAscendingRadioButton
            // 
            this.OrderByAscendingRadioButton.AutoSize = true;
            this.OrderByAscendingRadioButton.Location = new System.Drawing.Point(81, 119);
            this.OrderByAscendingRadioButton.Name = "OrderByAscendingRadioButton";
            this.OrderByAscendingRadioButton.Size = new System.Drawing.Size(75, 17);
            this.OrderByAscendingRadioButton.TabIndex = 9;
            this.OrderByAscendingRadioButton.TabStop = true;
            this.OrderByAscendingRadioButton.Text = "Ascending";
            this.OrderByAscendingRadioButton.UseVisualStyleBackColor = true;
            this.OrderByAscendingRadioButton.Visible = false;
            // 
            // OrderByCheckBox
            // 
            this.OrderByCheckBox.AutoSize = true;
            this.OrderByCheckBox.Location = new System.Drawing.Point(5, 119);
            this.OrderByCheckBox.Name = "OrderByCheckBox";
            this.OrderByCheckBox.Size = new System.Drawing.Size(69, 17);
            this.OrderByCheckBox.TabIndex = 8;
            this.OrderByCheckBox.Text = "Order by ";
            this.OrderByCheckBox.UseVisualStyleBackColor = true;
            this.OrderByCheckBox.CheckedChanged += new System.EventHandler(this.OrderByCheckBox_CheckedChanged);
            // 
            // OrderCountIfCheckBox
            // 
            this.OrderCountIfCheckBox.AutoSize = true;
            this.OrderCountIfCheckBox.Location = new System.Drawing.Point(6, 95);
            this.OrderCountIfCheckBox.Name = "OrderCountIfCheckBox";
            this.OrderCountIfCheckBox.Size = new System.Drawing.Size(141, 17);
            this.OrderCountIfCheckBox.TabIndex = 7;
            this.OrderCountIfCheckBox.Text = "Order Count More Than:";
            this.OrderCountIfCheckBox.UseVisualStyleBackColor = true;
            // 
            // OrderCountTextBox
            // 
            this.OrderCountTextBox.Location = new System.Drawing.Point(153, 93);
            this.OrderCountTextBox.Name = "OrderCountTextBox";
            this.OrderCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrderCountTextBox.TabIndex = 6;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(6, 32);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(84, 13);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Choose Gender:";
            // 
            // SelectedGenderComboBox
            // 
            this.SelectedGenderComboBox.FormattingEnabled = true;
            this.SelectedGenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SelectedGenderComboBox.Location = new System.Drawing.Point(96, 29);
            this.SelectedGenderComboBox.Name = "SelectedGenderComboBox";
            this.SelectedGenderComboBox.Size = new System.Drawing.Size(121, 21);
            this.SelectedGenderComboBox.TabIndex = 3;
            // 
            // CompletedOrderCheckBox
            // 
            this.CompletedOrderCheckBox.AutoSize = true;
            this.CompletedOrderCheckBox.Location = new System.Drawing.Point(6, 70);
            this.CompletedOrderCheckBox.Name = "CompletedOrderCheckBox";
            this.CompletedOrderCheckBox.Size = new System.Drawing.Size(165, 17);
            this.CompletedOrderCheckBox.TabIndex = 2;
            this.CompletedOrderCheckBox.Text = "Count Only Completed Orders";
            this.CompletedOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // Select_Button
            // 
            this.Select_Button.Location = new System.Drawing.Point(288, 152);
            this.Select_Button.Name = "Select_Button";
            this.Select_Button.Size = new System.Drawing.Size(155, 23);
            this.Select_Button.TabIndex = 1;
            this.Select_Button.Text = "Show with this params";
            this.Select_Button.UseVisualStyleBackColor = true;
            this.Select_Button.Click += new System.EventHandler(this.Select_Button_Click);
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.SubqueryGroupBox);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Size = new System.Drawing.Size(739, 481);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Subquery examples";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(0, 137);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.Size = new System.Drawing.Size(739, 344);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // SubqueryGroupBox
            // 
            this.SubqueryGroupBox.Controls.Add(this.labelBrand);
            this.SubqueryGroupBox.Controls.Add(this.buttonSubquery);
            this.SubqueryGroupBox.Controls.Add(this.textBoxBrand);
            this.SubqueryGroupBox.Controls.Add(this.radioButtonNoCorrelated);
            this.SubqueryGroupBox.Controls.Add(this.radioButtonCorrelated);
            this.SubqueryGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubqueryGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SubqueryGroupBox.Name = "SubqueryGroupBox";
            this.SubqueryGroupBox.Size = new System.Drawing.Size(739, 137);
            this.SubqueryGroupBox.TabIndex = 0;
            this.SubqueryGroupBox.TabStop = false;
            this.SubqueryGroupBox.Text = "Subquery";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(95, 68);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(81, 13);
            this.labelBrand.TabIndex = 4;
            this.labelBrand.Text = "Type Car Brand";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(183, 100);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(118, 23);
            this.buttonSubquery.TabIndex = 3;
            this.buttonSubquery.Text = "Exec. Subquery";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(201, 68);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrand.TabIndex = 2;
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(201, 31);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(184, 17);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированый Подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(24, 31);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(171, 17);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированый Подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.buttonSelectClient);
            this.tabPageDML.Controls.Add(this.dataGridViewClient);
            this.tabPageDML.Controls.Add(this.panelClient);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 22);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Size = new System.Drawing.Size(739, 481);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewClient.Location = new System.Drawing.Point(0, 238);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.Size = new System.Drawing.Size(739, 243);
            this.dataGridViewClient.TabIndex = 6;
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(full_NameLabel);
            this.panelClient.Controls.Add(this.full_NameTextBox);
            this.panelClient.Controls.Add(phone_NumberLabel);
            this.panelClient.Controls.Add(this.phone_NumberTextBox);
            this.panelClient.Controls.Add(genderLabel);
            this.panelClient.Controls.Add(this.genderComboBox);
            this.panelClient.Location = new System.Drawing.Point(3, 94);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(733, 109);
            this.panelClient.TabIndex = 5;
            // 
            // buttonSelectClient
            // 
            this.buttonSelectClient.Location = new System.Drawing.Point(309, 209);
            this.buttonSelectClient.Name = "buttonSelectClient";
            this.buttonSelectClient.Size = new System.Drawing.Size(96, 23);
            this.buttonSelectClient.TabIndex = 8;
            this.buttonSelectClient.Text = "Show Clients";
            this.buttonSelectClient.UseVisualStyleBackColor = true;
            this.buttonSelectClient.Click += new System.EventHandler(this.buttonSelectClientsClick);
            // 
            // full_NameTextBox
            // 
            this.full_NameTextBox.Location = new System.Drawing.Point(103, 13);
            this.full_NameTextBox.Name = "full_NameTextBox";
            this.full_NameTextBox.Size = new System.Drawing.Size(121, 20);
            this.full_NameTextBox.TabIndex = 3;
            // 
            // phone_NumberTextBox
            // 
            this.phone_NumberTextBox.Location = new System.Drawing.Point(103, 39);
            this.phone_NumberTextBox.Name = "phone_NumberTextBox";
            this.phone_NumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.phone_NumberTextBox.TabIndex = 5;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male  ",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(103, 65);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 21);
            this.genderComboBox.TabIndex = 7;
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.textBoxClient_ID);
            this.groupBoxDML.Controls.Add(this.labelClient_ID);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete_Client);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate_Client);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_Client);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(739, 88);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(321, 54);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(75, 23);
            this.buttonExecuteDML.TabIndex = 5;
            this.buttonExecuteDML.Text = "Exec DML";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // textBoxClient_ID
            // 
            this.textBoxClient_ID.Location = new System.Drawing.Point(117, 59);
            this.textBoxClient_ID.Name = "textBoxClient_ID";
            this.textBoxClient_ID.Size = new System.Drawing.Size(100, 20);
            this.textBoxClient_ID.TabIndex = 4;
            // 
            // labelClient_ID
            // 
            this.labelClient_ID.AutoSize = true;
            this.labelClient_ID.Location = new System.Drawing.Point(29, 59);
            this.labelClient_ID.Name = "labelClient_ID";
            this.labelClient_ID.Size = new System.Drawing.Size(47, 13);
            this.labelClient_ID.TabIndex = 3;
            this.labelClient_ID.Text = "Client ID";
            // 
            // radioButtonDelete_Client
            // 
            this.radioButtonDelete_Client.AutoSize = true;
            this.radioButtonDelete_Client.Location = new System.Drawing.Point(211, 19);
            this.radioButtonDelete_Client.Name = "radioButtonDelete_Client";
            this.radioButtonDelete_Client.Size = new System.Drawing.Size(85, 17);
            this.radioButtonDelete_Client.TabIndex = 2;
            this.radioButtonDelete_Client.TabStop = true;
            this.radioButtonDelete_Client.Text = "Delete Client";
            this.radioButtonDelete_Client.UseVisualStyleBackColor = true;
            this.radioButtonDelete_Client.CheckedChanged += new System.EventHandler(this.radioButtonDelete_Client_CheckedChanged);
            // 
            // radioButtonUpdate_Client
            // 
            this.radioButtonUpdate_Client.AutoSize = true;
            this.radioButtonUpdate_Client.Location = new System.Drawing.Point(99, 19);
            this.radioButtonUpdate_Client.Name = "radioButtonUpdate_Client";
            this.radioButtonUpdate_Client.Size = new System.Drawing.Size(110, 17);
            this.radioButtonUpdate_Client.TabIndex = 1;
            this.radioButtonUpdate_Client.TabStop = true;
            this.radioButtonUpdate_Client.Text = "Update Client Info";
            this.radioButtonUpdate_Client.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert_Client
            // 
            this.radioButtonInsert_Client.AutoSize = true;
            this.radioButtonInsert_Client.Location = new System.Drawing.Point(8, 19);
            this.radioButtonInsert_Client.Name = "radioButtonInsert_Client";
            this.radioButtonInsert_Client.Size = new System.Drawing.Size(80, 17);
            this.radioButtonInsert_Client.TabIndex = 0;
            this.radioButtonInsert_Client.TabStop = true;
            this.radioButtonInsert_Client.Text = "Insert Client";
            this.radioButtonInsert_Client.UseVisualStyleBackColor = true;
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 507);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPageExamples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.SelectGroupBox.ResumeLayout(false);
            this.SelectGroupBox.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.SubqueryGroupBox.ResumeLayout(false);
            this.SubqueryGroupBox.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPageExamples;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonOrder;
        private System.Windows.Forms.RadioButton radioButtonClient;
        private System.Windows.Forms.RadioButton radioButtonEmployee;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Select_Button;
        private System.Windows.Forms.GroupBox SelectGroupBox;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox SelectedGenderComboBox;
        private System.Windows.Forms.CheckBox CompletedOrderCheckBox;
        private System.Windows.Forms.CheckBox OrderCountIfCheckBox;
        private System.Windows.Forms.TextBox OrderCountTextBox;
        private System.Windows.Forms.RadioButton OrderByDescendingRadioButton;
        private System.Windows.Forms.RadioButton OrderByAscendingRadioButton;
        private System.Windows.Forms.CheckBox OrderByCheckBox;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.GroupBox SubqueryGroupBox;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.TextBox textBoxClient_ID;
        private System.Windows.Forms.Label labelClient_ID;
        private System.Windows.Forms.RadioButton radioButtonDelete_Client;
        private System.Windows.Forms.RadioButton radioButtonUpdate_Client;
        private System.Windows.Forms.RadioButton radioButtonInsert_Client;
        private System.Windows.Forms.TextBox full_NameTextBox;
        private System.Windows.Forms.TextBox phone_NumberTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.Button buttonSelectClient;
    }
}