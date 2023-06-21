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
            this.tabControlSQL.SuspendLayout();
            this.tabPageExamples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SelectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPageExamples);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(747, 528);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPageExamples
            // 
            this.tabPageExamples.Controls.Add(this.dataGridViewSelect);
            this.tabPageExamples.Controls.Add(this.groupBoxSelect);
            this.tabPageExamples.Location = new System.Drawing.Point(4, 22);
            this.tabPageExamples.Name = "tabPageExamples";
            this.tabPageExamples.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExamples.Size = new System.Drawing.Size(739, 502);
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
            this.dataGridViewSelect.Size = new System.Drawing.Size(733, 405);
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
            this.tabPageSelect.Size = new System.Drawing.Size(739, 502);
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
            this.dataGridView.Size = new System.Drawing.Size(733, 315);
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
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 528);
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
    }
}