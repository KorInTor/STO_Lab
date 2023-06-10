namespace STO_Lab
{
    partial class FormEmployeesList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label full_NameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label experienceLabel;
            System.Windows.Forms.Label scheduleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeesList));
            this.sTODataSet = new STO_Lab.STODataSet();
            this.employee_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_TableTableAdapter = new STO_Lab.STODataSetTableAdapters.Employee_TableTableAdapter();
            this.tableAdapterManager = new STO_Lab.STODataSetTableAdapters.TableAdapterManager();
            this.employee_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employee_TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.full_NameTextBox = new System.Windows.Forms.TextBox();
            this.experienceTextBox = new System.Windows.Forms.TextBox();
            this.scheduleTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            iDLabel = new System.Windows.Forms.Label();
            full_NameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            experienceLabel = new System.Windows.Forms.Label();
            scheduleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_TableBindingNavigator)).BeginInit();
            this.employee_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(202, 41);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // full_NameLabel
            // 
            full_NameLabel.AutoSize = true;
            full_NameLabel.Location = new System.Drawing.Point(200, 70);
            full_NameLabel.Name = "full_NameLabel";
            full_NameLabel.Size = new System.Drawing.Size(57, 13);
            full_NameLabel.TabIndex = 3;
            full_NameLabel.Text = "Full Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(202, 100);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 5;
            genderLabel.Text = "Gender:";
            // 
            // experienceLabel
            // 
            experienceLabel.AutoSize = true;
            experienceLabel.Location = new System.Drawing.Point(202, 129);
            experienceLabel.Name = "experienceLabel";
            experienceLabel.Size = new System.Drawing.Size(63, 13);
            experienceLabel.TabIndex = 7;
            experienceLabel.Text = "Experience:";
            // 
            // scheduleLabel
            // 
            scheduleLabel.AutoSize = true;
            scheduleLabel.Location = new System.Drawing.Point(202, 160);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new System.Drawing.Size(55, 13);
            scheduleLabel.TabIndex = 9;
            scheduleLabel.Text = "Schedule:";
            // 
            // sTODataSet
            // 
            this.sTODataSet.DataSetName = "STODataSet";
            this.sTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_TableBindingSource
            // 
            this.employee_TableBindingSource.DataMember = "Employee_Table";
            this.employee_TableBindingSource.DataSource = this.sTODataSet;
            // 
            // employee_TableTableAdapter
            // 
            this.employee_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Auto_TableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Client_TableTableAdapter = null;
            this.tableAdapterManager.Employee_TableTableAdapter = this.employee_TableTableAdapter;
            this.tableAdapterManager.Order_Employee_Rel_TableTableAdapter = null;
            this.tableAdapterManager.Order_TableTableAdapter = null;
            this.tableAdapterManager.Parts_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = STO_Lab.STODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Used_Parts_TableTableAdapter = null;
            // 
            // employee_TableBindingNavigator
            // 
            this.employee_TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employee_TableBindingNavigator.BindingSource = this.employee_TableBindingSource;
            this.employee_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employee_TableBindingNavigator.CountItemFormat = "из {0}";
            this.employee_TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employee_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.employee_TableBindingNavigatorSaveItem});
            this.employee_TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employee_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employee_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employee_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employee_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employee_TableBindingNavigator.Name = "employee_TableBindingNavigator";
            this.employee_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employee_TableBindingNavigator.Size = new System.Drawing.Size(509, 25);
            this.employee_TableBindingNavigator.TabIndex = 0;
            this.employee_TableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // employee_TableBindingNavigatorSaveItem
            // 
            this.employee_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employee_TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employee_TableBindingNavigatorSaveItem.Image")));
            this.employee_TableBindingNavigatorSaveItem.Name = "employee_TableBindingNavigatorSaveItem";
            this.employee_TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employee_TableBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.employee_TableBindingNavigatorSaveItem.Click += new System.EventHandler(this.employee_TableBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employee_TableBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(271, 38);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(34, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // full_NameTextBox
            // 
            this.full_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employee_TableBindingSource, "Full_Name", true));
            this.full_NameTextBox.Location = new System.Drawing.Point(271, 67);
            this.full_NameTextBox.Name = "full_NameTextBox";
            this.full_NameTextBox.Size = new System.Drawing.Size(214, 20);
            this.full_NameTextBox.TabIndex = 4;
            // 
            // experienceTextBox
            // 
            this.experienceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employee_TableBindingSource, "Experience", true));
            this.experienceTextBox.Location = new System.Drawing.Point(271, 126);
            this.experienceTextBox.Name = "experienceTextBox";
            this.experienceTextBox.Size = new System.Drawing.Size(56, 20);
            this.experienceTextBox.TabIndex = 8;
            // 
            // scheduleTextBox
            // 
            this.scheduleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employee_TableBindingSource, "Schedule", true));
            this.scheduleTextBox.Location = new System.Drawing.Point(271, 157);
            this.scheduleTextBox.Multiline = true;
            this.scheduleTextBox.Name = "scheduleTextBox";
            this.scheduleTextBox.Size = new System.Drawing.Size(176, 93);
            this.scheduleTextBox.TabIndex = 10;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.employee_TableBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(15, 41);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(161, 180);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 12;
            this.photoPictureBox.TabStop = false;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employee_TableBindingSource, "Gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(271, 97);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(111, 21);
            this.genderComboBox.TabIndex = 13;
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(15, 246);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(161, 23);
            this.buttonOpenPhoto.TabIndex = 14;
            this.buttonOpenPhoto.Text = "Open Photo";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto.Click += new System.EventHandler(this.buttonOpenPhoto_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // FormEmployeesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 272);
            this.Controls.Add(this.buttonOpenPhoto);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(full_NameLabel);
            this.Controls.Add(this.full_NameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(experienceLabel);
            this.Controls.Add(this.experienceTextBox);
            this.Controls.Add(scheduleLabel);
            this.Controls.Add(this.scheduleTextBox);
            this.Controls.Add(this.employee_TableBindingNavigator);
            this.Name = "FormEmployeesList";
            this.Text = "Список Сотрудников";
            this.Load += new System.EventHandler(this.FormEmployeesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_TableBindingNavigator)).EndInit();
            this.employee_TableBindingNavigator.ResumeLayout(false);
            this.employee_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private STODataSet sTODataSet;
        private System.Windows.Forms.BindingSource employee_TableBindingSource;
        private STODataSetTableAdapters.Employee_TableTableAdapter employee_TableTableAdapter;
        private STODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employee_TableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton employee_TableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox full_NameTextBox;
        private System.Windows.Forms.TextBox experienceTextBox;
        private System.Windows.Forms.TextBox scheduleTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Button buttonOpenPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
    }
}