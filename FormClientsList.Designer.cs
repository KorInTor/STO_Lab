namespace STO_Lab
{
    partial class FormClientsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientsList));
            this.sTODataSet = new STO_Lab.STODataSet();
            this.client_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_TableTableAdapter = new STO_Lab.STODataSetTableAdapters.Client_TableTableAdapter();
            this.tableAdapterManager = new STO_Lab.STODataSetTableAdapters.TableAdapterManager();
            this.client_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.client_TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.client_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnPol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.checkBoxFind = new System.Windows.Forms.CheckBox();
            this.ClientsGroupBox = new System.Windows.Forms.GroupBox();
            this.AutoListGroupBox = new System.Windows.Forms.GroupBox();
            this.auto_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auto_TableTableAdapter = new STO_Lab.STODataSetTableAdapters.Auto_TableTableAdapter();
            this.auto_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.auto_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_TableBindingNavigator)).BeginInit();
            this.client_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.client_TableDataGridView)).BeginInit();
            this.ClientsGroupBox.SuspendLayout();
            this.AutoListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auto_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto_TableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto_TableBindingNavigator)).BeginInit();
            this.auto_TableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // sTODataSet
            // 
            this.sTODataSet.DataSetName = "STODataSet";
            this.sTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // client_TableBindingSource
            // 
            this.client_TableBindingSource.DataMember = "Client_Table";
            this.client_TableBindingSource.DataSource = this.sTODataSet;
            // 
            // client_TableTableAdapter
            // 
            this.client_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Auto_TableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Client_TableTableAdapter = this.client_TableTableAdapter;
            this.tableAdapterManager.Employee_TableTableAdapter = null;
            this.tableAdapterManager.Order_Employee_Rel_TableTableAdapter = null;
            this.tableAdapterManager.Order_TableTableAdapter = null;
            this.tableAdapterManager.Parts_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = STO_Lab.STODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Used_Parts_TableTableAdapter = null;
            // 
            // client_TableBindingNavigator
            // 
            this.client_TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.client_TableBindingNavigator.BindingSource = this.client_TableBindingSource;
            this.client_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.client_TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.client_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.client_TableBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripTextBoxFind,
            this.toolStripButtonFind});
            this.client_TableBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.client_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.client_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.client_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.client_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.client_TableBindingNavigator.Name = "client_TableBindingNavigator";
            this.client_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.client_TableBindingNavigator.Size = new System.Drawing.Size(679, 25);
            this.client_TableBindingNavigator.TabIndex = 0;
            this.client_TableBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
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
            // client_TableBindingNavigatorSaveItem
            // 
            this.client_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.client_TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("client_TableBindingNavigatorSaveItem.Image")));
            this.client_TableBindingNavigatorSaveItem.Name = "client_TableBindingNavigatorSaveItem";
            this.client_TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.client_TableBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.client_TableBindingNavigatorSaveItem.Click += new System.EventHandler(this.client_TableBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBoxFind
            // 
            this.toolStripTextBoxFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
            this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxFind.ToolTipText = "Введите здесь значение для поиска";
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.Image = global::STO_Lab.Properties.Resources.find;
            this.toolStripButtonFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(62, 22);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // client_TableDataGridView
            // 
            this.client_TableDataGridView.AutoGenerateColumns = false;
            this.client_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.client_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumnPol});
            this.client_TableDataGridView.DataSource = this.client_TableBindingSource;
            this.client_TableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.client_TableDataGridView.Location = new System.Drawing.Point(3, 41);
            this.client_TableDataGridView.Name = "client_TableDataGridView";
            this.client_TableDataGridView.Size = new System.Drawing.Size(679, 424);
            this.client_TableDataGridView.TabIndex = 1;
            this.client_TableDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.client_DataGridView_CellFormatting);
            this.client_TableDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.client_TableDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Client_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Full_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Full_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone_Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone_Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumnPol
            // 
            this.dataGridViewTextBoxColumnPol.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumnPol.HeaderText = "Gender";
            this.dataGridViewTextBoxColumnPol.Items.AddRange(new object[] {
            "Male  ",
            "Female"});
            this.dataGridViewTextBoxColumnPol.Name = "dataGridViewTextBoxColumnPol";
            this.dataGridViewTextBoxColumnPol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumnPol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // checkBoxFind
            // 
            this.checkBoxFind.AutoSize = true;
            this.checkBoxFind.Location = new System.Drawing.Point(458, 19);
            this.checkBoxFind.Name = "checkBoxFind";
            this.checkBoxFind.Size = new System.Drawing.Size(66, 17);
            this.checkBoxFind.TabIndex = 2;
            this.checkBoxFind.Text = "Фильтр";
            this.checkBoxFind.UseVisualStyleBackColor = true;
            this.checkBoxFind.CheckedChanged += new System.EventHandler(this.checkBoxFind_CheckedChanged);
            // 
            // ClientsGroupBox
            // 
            this.ClientsGroupBox.Controls.Add(this.client_TableDataGridView);
            this.ClientsGroupBox.Controls.Add(this.checkBoxFind);
            this.ClientsGroupBox.Controls.Add(this.client_TableBindingNavigator);
            this.ClientsGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClientsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ClientsGroupBox.Name = "ClientsGroupBox";
            this.ClientsGroupBox.Size = new System.Drawing.Size(685, 468);
            this.ClientsGroupBox.TabIndex = 3;
            this.ClientsGroupBox.TabStop = false;
            this.ClientsGroupBox.Text = "Clients List";
            // 
            // AutoListGroupBox
            // 
            this.AutoListGroupBox.Controls.Add(this.auto_TableDataGridView);
            this.AutoListGroupBox.Controls.Add(this.auto_TableBindingNavigator);
            this.AutoListGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.AutoListGroupBox.Location = new System.Drawing.Point(691, 0);
            this.AutoListGroupBox.Name = "AutoListGroupBox";
            this.AutoListGroupBox.Size = new System.Drawing.Size(531, 468);
            this.AutoListGroupBox.TabIndex = 4;
            this.AutoListGroupBox.TabStop = false;
            this.AutoListGroupBox.Text = "Auto List";
            // 
            // auto_TableBindingSource
            // 
            this.auto_TableBindingSource.DataMember = "FK_Auto_Table_Client_Table";
            this.auto_TableBindingSource.DataSource = this.client_TableBindingSource;
            // 
            // auto_TableTableAdapter
            // 
            this.auto_TableTableAdapter.ClearBeforeFill = true;
            // 
            // auto_TableDataGridView
            // 
            this.auto_TableDataGridView.AutoGenerateColumns = false;
            this.auto_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auto_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.auto_TableDataGridView.DataSource = this.auto_TableBindingSource;
            this.auto_TableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auto_TableDataGridView.Location = new System.Drawing.Point(3, 41);
            this.auto_TableDataGridView.Name = "auto_TableDataGridView";
            this.auto_TableDataGridView.Size = new System.Drawing.Size(525, 424);
            this.auto_TableDataGridView.TabIndex = 0;
            // 
            // auto_TableBindingNavigator
            // 
            this.auto_TableBindingNavigator.AddNewItem = this.toolStripButton1;
            this.auto_TableBindingNavigator.BindingSource = this.auto_TableBindingSource;
            this.auto_TableBindingNavigator.CountItem = this.toolStripLabel1;
            this.auto_TableBindingNavigator.DeleteItem = this.toolStripButton2;
            this.auto_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7,
            this.toolStripSeparator5,
            this.toolStripTextBox2,
            this.toolStripButton8});
            this.auto_TableBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.auto_TableBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.auto_TableBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.auto_TableBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.auto_TableBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.auto_TableBindingNavigator.Name = "auto_TableBindingNavigator";
            this.auto_TableBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.auto_TableBindingNavigator.Size = new System.Drawing.Size(525, 25);
            this.auto_TableBindingNavigator.TabIndex = 1;
            this.auto_TableBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Сохранить данные";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox2.ToolTipText = "Введите здесь значение для поиска";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = global::STO_Lab.Properties.Resources.find;
            this.toolStripButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton8.Text = "Поиск";
            this.toolStripButton8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Client_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Client_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VIN_Code";
            this.dataGridViewTextBoxColumn4.HeaderText = "VIN_Code";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Brand";
            this.dataGridViewTextBoxColumn6.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn7.HeaderText = "Model";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Gov_Number";
            this.dataGridViewTextBoxColumn8.HeaderText = "Gov_Number";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Gov_Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Gov_Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // FormClientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 468);
            this.Controls.Add(this.AutoListGroupBox);
            this.Controls.Add(this.ClientsGroupBox);
            this.Name = "FormClientsList";
            this.Text = "Список Клиентов и Авто";
            this.Load += new System.EventHandler(this.FormClientsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_TableBindingNavigator)).EndInit();
            this.client_TableBindingNavigator.ResumeLayout(false);
            this.client_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.client_TableDataGridView)).EndInit();
            this.ClientsGroupBox.ResumeLayout(false);
            this.ClientsGroupBox.PerformLayout();
            this.AutoListGroupBox.ResumeLayout(false);
            this.AutoListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auto_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto_TableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto_TableBindingNavigator)).EndInit();
            this.auto_TableBindingNavigator.ResumeLayout(false);
            this.auto_TableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private STODataSet sTODataSet;
        private System.Windows.Forms.BindingSource client_TableBindingSource;
        private STODataSetTableAdapters.Client_TableTableAdapter client_TableTableAdapter;
        private STODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator client_TableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton client_TableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView client_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumnPol;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.CheckBox checkBoxFind;
        private System.Windows.Forms.GroupBox ClientsGroupBox;
        private System.Windows.Forms.GroupBox AutoListGroupBox;
        private System.Windows.Forms.BindingSource auto_TableBindingSource;
        private STODataSetTableAdapters.Auto_TableTableAdapter auto_TableTableAdapter;
        private System.Windows.Forms.DataGridView auto_TableDataGridView;
        private System.Windows.Forms.BindingNavigator auto_TableBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}