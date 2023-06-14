namespace STO_Lab
{
    partial class FormOrderList
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
            System.Windows.Forms.Label defects_ListLabel;
            System.Windows.Forms.Label fixed_Defects_ListLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderList));
            this.order_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.defects_ListTextBox = new System.Windows.Forms.TextBox();
            this.fixed_Defects_ListTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.order_TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.order_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.EmployesTableGroupBox = new System.Windows.Forms.GroupBox();
            this.order_Employee_Rel_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.order_Employee_Rel_TableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.order_Employee_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.UsedPartsGroupBox = new System.Windows.Forms.GroupBox();
            this.Car_Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.used_Parts_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.used_Parts_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.used_Parts_Table_BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.order_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTODataSet = new STO_Lab.STODataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtomEmployee = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_TableTableAdapter = new STO_Lab.STODataSetTableAdapters.Order_TableTableAdapter();
            this.tableAdapterManager = new STO_Lab.STODataSetTableAdapters.TableAdapterManager();
            this.order_Employee_Rel_TableTableAdapter = new STO_Lab.STODataSetTableAdapters.Order_Employee_Rel_TableTableAdapter();
            this.auto_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auto_TableTableAdapter = new STO_Lab.STODataSetTableAdapters.Auto_TableTableAdapter();
            this.employee_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_TableTableAdapter = new STO_Lab.STODataSetTableAdapters.Employee_TableTableAdapter();
            this.used_Parts_TableTableAdapter = new STO_Lab.STODataSetTableAdapters.Used_Parts_TableTableAdapter();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            defects_ListLabel = new System.Windows.Forms.Label();
            fixed_Defects_ListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.order_TableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_TableBindingNavigator)).BeginInit();
            this.order_TableBindingNavigator.SuspendLayout();
            this.EmployesTableGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_Employee_Rel_TableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_Employee_Rel_TableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_Employee_TableBindingNavigator)).BeginInit();
            this.order_Employee_TableBindingNavigator.SuspendLayout();
            this.OrderGroupBox.SuspendLayout();
            this.UsedPartsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.used_Parts_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.used_Parts_TableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.used_Parts_Table_BindingNavigator)).BeginInit();
            this.used_Parts_Table_BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_TableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // defects_ListLabel
            // 
            defects_ListLabel.AutoSize = true;
            defects_ListLabel.Location = new System.Drawing.Point(648, 48);
            defects_ListLabel.Name = "defects_ListLabel";
            defects_ListLabel.Size = new System.Drawing.Size(66, 13);
            defects_ListLabel.TabIndex = 2;
            defects_ListLabel.Text = "Defects List:";
            // 
            // fixed_Defects_ListLabel
            // 
            fixed_Defects_ListLabel.AutoSize = true;
            fixed_Defects_ListLabel.Location = new System.Drawing.Point(618, 292);
            fixed_Defects_ListLabel.Name = "fixed_Defects_ListLabel";
            fixed_Defects_ListLabel.Size = new System.Drawing.Size(94, 13);
            fixed_Defects_ListLabel.TabIndex = 4;
            fixed_Defects_ListLabel.Text = "Fixed Defects List:";
            // 
            // order_TableDataGridView
            // 
            this.order_TableDataGridView.AutoGenerateColumns = false;
            this.order_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.Car_Info,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.order_TableDataGridView.DataSource = this.order_TableBindingSource;
            this.order_TableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_TableDataGridView.Location = new System.Drawing.Point(3, 16);
            this.order_TableDataGridView.Name = "order_TableDataGridView";
            this.order_TableDataGridView.Size = new System.Drawing.Size(603, 260);
            this.order_TableDataGridView.TabIndex = 1;
            // 
            // defects_ListTextBox
            // 
            this.defects_ListTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_TableBindingSource, "Defects_List", true));
            this.defects_ListTextBox.Location = new System.Drawing.Point(720, 45);
            this.defects_ListTextBox.Multiline = true;
            this.defects_ListTextBox.Name = "defects_ListTextBox";
            this.defects_ListTextBox.Size = new System.Drawing.Size(165, 222);
            this.defects_ListTextBox.TabIndex = 3;
            // 
            // fixed_Defects_ListTextBox
            // 
            this.fixed_Defects_ListTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_TableBindingSource, "Fixed_Defects_List", true));
            this.fixed_Defects_ListTextBox.Location = new System.Drawing.Point(720, 289);
            this.fixed_Defects_ListTextBox.Multiline = true;
            this.fixed_Defects_ListTextBox.Name = "fixed_Defects_ListTextBox";
            this.fixed_Defects_ListTextBox.Size = new System.Drawing.Size(165, 227);
            this.fixed_Defects_ListTextBox.TabIndex = 5;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
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
            // order_TableBindingNavigatorSaveItem
            // 
            this.order_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.order_TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("order_TableBindingNavigatorSaveItem.Image")));
            this.order_TableBindingNavigatorSaveItem.Name = "order_TableBindingNavigatorSaveItem";
            this.order_TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.order_TableBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.order_TableBindingNavigatorSaveItem.Click += new System.EventHandler(this.order_Employee_TableBindingNavigatorSaveItem_Click);
            // 
            // order_TableBindingNavigator
            // 
            this.order_TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.order_TableBindingNavigator.BindingSource = this.order_TableBindingSource;
            this.order_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.order_TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.order_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.order_TableBindingNavigatorSaveItem});
            this.order_TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.order_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.order_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.order_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.order_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.order_TableBindingNavigator.Name = "order_TableBindingNavigator";
            this.order_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.order_TableBindingNavigator.Size = new System.Drawing.Size(1401, 25);
            this.order_TableBindingNavigator.TabIndex = 0;
            this.order_TableBindingNavigator.Text = "bindingNavigator1";
            // 
            // EmployesTableGroupBox
            // 
            this.EmployesTableGroupBox.Controls.Add(this.order_Employee_Rel_TableDataGridView);
            this.EmployesTableGroupBox.Controls.Add(this.order_Employee_TableBindingNavigator);
            this.EmployesTableGroupBox.Location = new System.Drawing.Point(6, 316);
            this.EmployesTableGroupBox.Name = "EmployesTableGroupBox";
            this.EmployesTableGroupBox.Size = new System.Drawing.Size(606, 203);
            this.EmployesTableGroupBox.TabIndex = 9;
            this.EmployesTableGroupBox.TabStop = false;
            this.EmployesTableGroupBox.Text = "Employes on that Order:";
            // 
            // order_Employee_Rel_TableDataGridView
            // 
            this.order_Employee_Rel_TableDataGridView.AutoGenerateColumns = false;
            this.order_Employee_Rel_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_Employee_Rel_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewButtomEmployee,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7});
            this.order_Employee_Rel_TableDataGridView.DataSource = this.order_Employee_Rel_TableBindingSource1;
            this.order_Employee_Rel_TableDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.order_Employee_Rel_TableDataGridView.Location = new System.Drawing.Point(3, 44);
            this.order_Employee_Rel_TableDataGridView.Name = "order_Employee_Rel_TableDataGridView";
            this.order_Employee_Rel_TableDataGridView.Size = new System.Drawing.Size(600, 156);
            this.order_Employee_Rel_TableDataGridView.TabIndex = 11;
            // 
            // order_Employee_Rel_TableBindingSource1
            // 
            this.order_Employee_Rel_TableBindingSource1.DataMember = "FK_Order_Employee_Rel_Table_Order_Tabel";
            this.order_Employee_Rel_TableBindingSource1.DataSource = this.order_TableBindingSource;
            // 
            // order_Employee_TableBindingNavigator
            // 
            this.order_Employee_TableBindingNavigator.AddNewItem = this.toolStripButton1;
            this.order_Employee_TableBindingNavigator.BindingSource = this.order_Employee_Rel_TableBindingSource1;
            this.order_Employee_TableBindingNavigator.CountItem = this.toolStripLabel1;
            this.order_Employee_TableBindingNavigator.DeleteItem = this.toolStripButton2;
            this.order_Employee_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.order_Employee_TableBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.order_Employee_TableBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.order_Employee_TableBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.order_Employee_TableBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.order_Employee_TableBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.order_Employee_TableBindingNavigator.Name = "order_Employee_TableBindingNavigator";
            this.order_Employee_TableBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.order_Employee_TableBindingNavigator.Size = new System.Drawing.Size(600, 25);
            this.order_Employee_TableBindingNavigator.TabIndex = 11;
            this.order_Employee_TableBindingNavigator.Text = "bindingNavigator1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Сохранить данные";
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Controls.Add(this.order_TableDataGridView);
            this.OrderGroupBox.Location = new System.Drawing.Point(3, 29);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(609, 279);
            this.OrderGroupBox.TabIndex = 10;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "OrderList";
            // 
            // UsedPartsGroupBox
            // 
            this.UsedPartsGroupBox.Controls.Add(this.used_Parts_TableDataGridView);
            this.UsedPartsGroupBox.Controls.Add(this.used_Parts_Table_BindingNavigator);
            this.UsedPartsGroupBox.Location = new System.Drawing.Point(905, 42);
            this.UsedPartsGroupBox.Name = "UsedPartsGroupBox";
            this.UsedPartsGroupBox.Size = new System.Drawing.Size(454, 474);
            this.UsedPartsGroupBox.TabIndex = 11;
            this.UsedPartsGroupBox.TabStop = false;
            this.UsedPartsGroupBox.Text = "Used Parts";
            // 
            // Car_Info
            // 
            this.Car_Info.DataPropertyName = "Car_Info";
            this.Car_Info.HeaderText = "Car_Info";
            this.Car_Info.Name = "Car_Info";
            this.Car_Info.ReadOnly = true;
            this.Car_Info.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // used_Parts_TableBindingSource
            // 
            this.used_Parts_TableBindingSource.DataMember = "FK_Used_Parts_Table_Order_Table";
            this.used_Parts_TableBindingSource.DataSource = this.order_TableBindingSource;
            // 
            // used_Parts_TableDataGridView
            // 
            this.used_Parts_TableDataGridView.AutoGenerateColumns = false;
            this.used_Parts_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.used_Parts_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10});
            this.used_Parts_TableDataGridView.DataSource = this.used_Parts_TableBindingSource;
            this.used_Parts_TableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.used_Parts_TableDataGridView.Location = new System.Drawing.Point(3, 41);
            this.used_Parts_TableDataGridView.Name = "used_Parts_TableDataGridView";
            this.used_Parts_TableDataGridView.Size = new System.Drawing.Size(448, 430);
            this.used_Parts_TableDataGridView.TabIndex = 0;
            // 
            // used_Parts_Table_BindingNavigator
            // 
            this.used_Parts_Table_BindingNavigator.AddNewItem = this.toolStripButton8;
            this.used_Parts_Table_BindingNavigator.BindingSource = this.order_Employee_Rel_TableBindingSource1;
            this.used_Parts_Table_BindingNavigator.CountItem = this.toolStripLabel2;
            this.used_Parts_Table_BindingNavigator.DeleteItem = this.toolStripButton9;
            this.used_Parts_Table_BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator6,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton14});
            this.used_Parts_Table_BindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.used_Parts_Table_BindingNavigator.MoveFirstItem = this.toolStripButton10;
            this.used_Parts_Table_BindingNavigator.MoveLastItem = this.toolStripButton13;
            this.used_Parts_Table_BindingNavigator.MoveNextItem = this.toolStripButton12;
            this.used_Parts_Table_BindingNavigator.MovePreviousItem = this.toolStripButton11;
            this.used_Parts_Table_BindingNavigator.Name = "used_Parts_Table_BindingNavigator";
            this.used_Parts_Table_BindingNavigator.PositionItem = this.toolStripTextBox2;
            this.used_Parts_Table_BindingNavigator.Size = new System.Drawing.Size(448, 25);
            this.used_Parts_Table_BindingNavigator.TabIndex = 12;
            this.used_Parts_Table_BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Добавить";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel2.Text = "для {0}";
            this.toolStripLabel2.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Удалить";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Переместить в начало";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Переместить назад";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Положение";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Переместить вперед";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Переместить в конец";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Сохранить данные";
            // 
            // order_TableBindingSource
            // 
            this.order_TableBindingSource.DataMember = "Order_Table";
            this.order_TableBindingSource.DataSource = this.sTODataSet;
            // 
            // sTODataSet
            // 
            this.sTODataSet.DataSetName = "STODataSet";
            this.sTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Order_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Order_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date_Issued";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date_Issued";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Auto_VINcode";
            this.dataGridViewTextBoxColumn6.HeaderText = "Auto_VINcode";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount_spent";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount_spent";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Status";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Employee_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewButtomEmployee
            // 
            this.dataGridViewButtomEmployee.DataPropertyName = "EmployeeInfo";
            this.dataGridViewButtomEmployee.HeaderText = "EmployeeInfo";
            this.dataGridViewButtomEmployee.Name = "dataGridViewButtomEmployee";
            this.dataGridViewButtomEmployee.ReadOnly = true;
            this.dataGridViewButtomEmployee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtomEmployee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Order_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Order_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Start_Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Start_Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // order_TableTableAdapter
            // 
            this.order_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Auto_TableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Client_TableTableAdapter = null;
            this.tableAdapterManager.Employee_TableTableAdapter = null;
            this.tableAdapterManager.Order_Employee_Rel_TableTableAdapter = null;
            this.tableAdapterManager.Order_TableTableAdapter = this.order_TableTableAdapter;
            this.tableAdapterManager.Parts_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = STO_Lab.STODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Used_Parts_TableTableAdapter = null;
            // 
            // order_Employee_Rel_TableTableAdapter
            // 
            this.order_Employee_Rel_TableTableAdapter.ClearBeforeFill = true;
            // 
            // auto_TableBindingSource
            // 
            this.auto_TableBindingSource.DataMember = "Auto_Table";
            this.auto_TableBindingSource.DataSource = this.sTODataSet;
            // 
            // auto_TableTableAdapter
            // 
            this.auto_TableTableAdapter.ClearBeforeFill = true;
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
            // used_Parts_TableTableAdapter
            // 
            this.used_Parts_TableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Order_ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "Order_ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Part_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Part_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn10.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 539);
            this.Controls.Add(this.UsedPartsGroupBox);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.EmployesTableGroupBox);
            this.Controls.Add(fixed_Defects_ListLabel);
            this.Controls.Add(this.fixed_Defects_ListTextBox);
            this.Controls.Add(defects_ListLabel);
            this.Controls.Add(this.defects_ListTextBox);
            this.Controls.Add(this.order_TableBindingNavigator);
            this.Name = "FormOrderList";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.order_TableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_TableBindingNavigator)).EndInit();
            this.order_TableBindingNavigator.ResumeLayout(false);
            this.order_TableBindingNavigator.PerformLayout();
            this.EmployesTableGroupBox.ResumeLayout(false);
            this.EmployesTableGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_Employee_Rel_TableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_Employee_Rel_TableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_Employee_TableBindingNavigator)).EndInit();
            this.order_Employee_TableBindingNavigator.ResumeLayout(false);
            this.order_Employee_TableBindingNavigator.PerformLayout();
            this.OrderGroupBox.ResumeLayout(false);
            this.UsedPartsGroupBox.ResumeLayout(false);
            this.UsedPartsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.used_Parts_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.used_Parts_TableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.used_Parts_Table_BindingNavigator)).EndInit();
            this.used_Parts_Table_BindingNavigator.ResumeLayout(false);
            this.used_Parts_Table_BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_TableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private STODataSet sTODataSet;
        private System.Windows.Forms.BindingSource order_TableBindingSource;
        private STODataSetTableAdapters.Order_TableTableAdapter order_TableTableAdapter;
        private STODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView order_TableDataGridView;
        private System.Windows.Forms.TextBox defects_ListTextBox;
        private System.Windows.Forms.TextBox fixed_Defects_ListTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton order_TableBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator order_TableBindingNavigator;
        private STODataSetTableAdapters.Order_Employee_Rel_TableTableAdapter order_Employee_Rel_TableTableAdapter;
        private System.Windows.Forms.GroupBox EmployesTableGroupBox;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.BindingNavigator order_Employee_TableBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource order_Employee_Rel_TableBindingSource1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.BindingSource auto_TableBindingSource;
        private STODataSetTableAdapters.Auto_TableTableAdapter auto_TableTableAdapter;
        private System.Windows.Forms.GroupBox UsedPartsGroupBox;
        private System.Windows.Forms.DataGridView order_Employee_Rel_TableDataGridView;
        private System.Windows.Forms.BindingSource employee_TableBindingSource;
        private STODataSetTableAdapters.Employee_TableTableAdapter employee_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtomEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car_Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource used_Parts_TableBindingSource;
        private STODataSetTableAdapters.Used_Parts_TableTableAdapter used_Parts_TableTableAdapter;
        private System.Windows.Forms.DataGridView used_Parts_TableDataGridView;
        private System.Windows.Forms.BindingNavigator used_Parts_Table_BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}