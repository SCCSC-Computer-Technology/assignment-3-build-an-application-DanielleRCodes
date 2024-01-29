namespace DanielleR_CPT_206_Lab_3
{
    partial class FormAdvFeatures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdvFeatures));
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblStateInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tblStateInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateInformationDBDataSet = new DanielleR_CPT_206_Lab_3.StateInformationDBDataSet();
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
            this.tblStateInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblStateInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxColumnsToSort = new System.Windows.Forms.ComboBox();
            this.btnSortASC = new System.Windows.Forms.Button();
            this.btnSortByDESC = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblOutputAverage = new System.Windows.Forms.Label();
            this.cboxFilterData = new System.Windows.Forms.ComboBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.tblStateInfoTableAdapter = new DanielleR_CPT_206_Lab_3.StateInformationDBDataSetTableAdapters.tblStateInfoTableAdapter();
            this.tableAdapterManager = new DanielleR_CPT_206_Lab_3.StateInformationDBDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStateInfoBindingNavigator)).BeginInit();
            this.tblStateInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStateInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStateInfoDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "State Information Program";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1154, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 54);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 93);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tblStateInfoBindingNavigator
            // 
            this.tblStateInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblStateInfoBindingNavigator.BindingSource = this.tblStateInfoBindingSource;
            this.tblStateInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblStateInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblStateInfoBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tblStateInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblStateInfoBindingNavigatorSaveItem});
            this.tblStateInfoBindingNavigator.Location = new System.Drawing.Point(0, 93);
            this.tblStateInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblStateInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblStateInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblStateInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblStateInfoBindingNavigator.Name = "tblStateInfoBindingNavigator";
            this.tblStateInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblStateInfoBindingNavigator.Size = new System.Drawing.Size(1216, 33);
            this.tblStateInfoBindingNavigator.TabIndex = 3;
            this.tblStateInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tblStateInfoBindingSource
            // 
            this.tblStateInfoBindingSource.DataMember = "tblStateInfo";
            this.tblStateInfoBindingSource.DataSource = this.stateInformationDBDataSet;
            // 
            // stateInformationDBDataSet
            // 
            this.stateInformationDBDataSet.DataSetName = "StateInformationDBDataSet";
            this.stateInformationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // tblStateInfoBindingNavigatorSaveItem
            // 
            this.tblStateInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblStateInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblStateInfoBindingNavigatorSaveItem.Image")));
            this.tblStateInfoBindingNavigatorSaveItem.Name = "tblStateInfoBindingNavigatorSaveItem";
            this.tblStateInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.tblStateInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.tblStateInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblStateInfoBindingNavigatorSaveItem_Click);
            // 
            // tblStateInfoDataGridView
            // 
            this.tblStateInfoDataGridView.AutoGenerateColumns = false;
            this.tblStateInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblStateInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.tblStateInfoDataGridView.DataSource = this.tblStateInfoBindingSource;
            this.tblStateInfoDataGridView.Location = new System.Drawing.Point(37, 150);
            this.tblStateInfoDataGridView.Name = "tblStateInfoDataGridView";
            this.tblStateInfoDataGridView.RowHeadersWidth = 62;
            this.tblStateInfoDataGridView.RowTemplate.Height = 28;
            this.tblStateInfoDataGridView.Size = new System.Drawing.Size(1158, 472);
            this.tblStateInfoDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "stateAbb";
            this.dataGridViewTextBoxColumn1.HeaderText = "State Abbreviation";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "stateName";
            this.dataGridViewTextBoxColumn2.HeaderText = "State Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "stateFlower";
            this.dataGridViewTextBoxColumn3.HeaderText = "State Flower";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stateBird";
            this.dataGridViewTextBoxColumn4.HeaderText = "State Bird";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "stateColors";
            this.dataGridViewTextBoxColumn5.HeaderText = "State Colors";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "stateFlagDescrip";
            this.dataGridViewTextBoxColumn6.HeaderText = "Flag Description";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "statePop";
            this.dataGridViewTextBoxColumn7.HeaderText = "Population";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "stateMedIncome";
            this.dataGridViewTextBoxColumn8.HeaderText = "Median Income";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "stateLargestCityOne";
            this.dataGridViewTextBoxColumn9.HeaderText = "Largest City";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "stateLargestCityTwo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Second Largest City";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "stateLargestCityThree";
            this.dataGridViewTextBoxColumn11.HeaderText = "Third Largest City";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "stateCompJobs";
            this.dataGridViewTextBoxColumn12.HeaderText = "Percentage of Comp-Related Jobs";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboxColumnsToSort);
            this.groupBox2.Controls.Add(this.btnSortASC);
            this.groupBox2.Controls.Add(this.btnSortByDESC);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(269, 642);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 194);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort Data";
            // 
            // cboxColumnsToSort
            // 
            this.cboxColumnsToSort.FormattingEnabled = true;
            this.cboxColumnsToSort.Items.AddRange(new object[] {
            "Abbreviation",
            "Name",
            "Flower",
            "Bird",
            "Colors",
            "Flag Description",
            "Population",
            "Median Income",
            "Largest City",
            "Second Largest City",
            "Third Largest City",
            "Percentage Comp Jobs"});
            this.cboxColumnsToSort.Location = new System.Drawing.Point(79, 54);
            this.cboxColumnsToSort.Name = "cboxColumnsToSort";
            this.cboxColumnsToSort.Size = new System.Drawing.Size(221, 32);
            this.cboxColumnsToSort.TabIndex = 14;
            // 
            // btnSortASC
            // 
            this.btnSortASC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(45)))), ((int)(((byte)(39)))));
            this.btnSortASC.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortASC.ForeColor = System.Drawing.Color.White;
            this.btnSortASC.Location = new System.Drawing.Point(17, 118);
            this.btnSortASC.Name = "btnSortASC";
            this.btnSortASC.Size = new System.Drawing.Size(162, 58);
            this.btnSortASC.TabIndex = 13;
            this.btnSortASC.Text = "Sort By, Asc";
            this.btnSortASC.UseVisualStyleBackColor = false;
            this.btnSortASC.Click += new System.EventHandler(this.btnSortASC_Click);
            // 
            // btnSortByDESC
            // 
            this.btnSortByDESC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(45)))), ((int)(((byte)(39)))));
            this.btnSortByDESC.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByDESC.ForeColor = System.Drawing.Color.White;
            this.btnSortByDESC.Location = new System.Drawing.Point(185, 118);
            this.btnSortByDESC.Name = "btnSortByDESC";
            this.btnSortByDESC.Size = new System.Drawing.Size(162, 58);
            this.btnSortByDESC.TabIndex = 12;
            this.btnSortByDESC.Text = "Sort By, Desc";
            this.btnSortByDESC.UseVisualStyleBackColor = false;
            this.btnSortByDESC.Click += new System.EventHandler(this.btnSortByDESC_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblOutputAverage);
            this.groupBox3.Controls.Add(this.cboxFilterData);
            this.groupBox3.Controls.Add(this.btnAverage);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(679, 642);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 194);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "National Average";
            // 
            // lblOutputAverage
            // 
            this.lblOutputAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputAverage.Location = new System.Drawing.Point(38, 105);
            this.lblOutputAverage.Name = "lblOutputAverage";
            this.lblOutputAverage.Size = new System.Drawing.Size(283, 71);
            this.lblOutputAverage.TabIndex = 16;
            this.lblOutputAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxFilterData
            // 
            this.cboxFilterData.FormattingEnabled = true;
            this.cboxFilterData.Items.AddRange(new object[] {
            "Population",
            "Median Income",
            "Percentage Comp Jobs"});
            this.cboxFilterData.Location = new System.Drawing.Point(14, 45);
            this.cboxFilterData.Name = "cboxFilterData";
            this.cboxFilterData.Size = new System.Drawing.Size(193, 32);
            this.cboxFilterData.TabIndex = 15;
            // 
            // btnAverage
            // 
            this.btnAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(45)))), ((int)(((byte)(39)))));
            this.btnAverage.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverage.ForeColor = System.Drawing.Color.White;
            this.btnAverage.Location = new System.Drawing.Point(224, 40);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(111, 41);
            this.btnAverage.TabIndex = 10;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = false;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // tblStateInfoTableAdapter
            // 
            this.tblStateInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblStateInfoTableAdapter = this.tblStateInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = DanielleR_CPT_206_Lab_3.StateInformationDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormAdvFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 848);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tblStateInfoDataGridView);
            this.Controls.Add(this.tblStateInfoBindingNavigator);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdvFeatures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdvFeatures";
            this.Load += new System.EventHandler(this.FormAdvFeatures_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStateInfoBindingNavigator)).EndInit();
            this.tblStateInfoBindingNavigator.ResumeLayout(false);
            this.tblStateInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStateInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInformationDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStateInfoDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private StateInformationDBDataSet stateInformationDBDataSet;
        private System.Windows.Forms.BindingSource tblStateInfoBindingSource;
        private StateInformationDBDataSetTableAdapters.tblStateInfoTableAdapter tblStateInfoTableAdapter;
        private StateInformationDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblStateInfoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblStateInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblStateInfoDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSortASC;
        private System.Windows.Forms.Button btnSortByDESC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.ComboBox cboxColumnsToSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ComboBox cboxFilterData;
        private System.Windows.Forms.Label lblOutputAverage;
    }
}