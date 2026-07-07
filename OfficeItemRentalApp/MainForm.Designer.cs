namespace OfficeItemRentalApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rootLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.itemListTabPage = new System.Windows.Forms.TabPage();
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.itemGridItemIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGridItemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGridCategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGridStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGridBorrowerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGridRentalDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGridDueDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGridAlertColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemGridRentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGridReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGridBorrowerSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGridHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerTabPage = new System.Windows.Forms.TabPage();
            this.registerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.itemIdLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.itemIdTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.registerButtonSpacerLabel = new System.Windows.Forms.Label();
            this.registerButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.registerButton = new System.Windows.Forms.Button();
            this.clearItemInputButton = new System.Windows.Forms.Button();
            this.registerNoteLabel = new System.Windows.Forms.Label();
            this.rentReturnTabPage = new System.Windows.Forms.TabPage();
            this.rentReturnSplitContainer = new System.Windows.Forms.SplitContainer();
            this.rentalItemGrid = new System.Windows.Forms.DataGridView();
            this.rentalItemGridItemIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalItemGridItemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalItemGridCategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalItemGridStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalItemGridBorrowerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalItemGridRentalDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalItemGridDueDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalItemGridAlertColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentReturnBottomLayout = new System.Windows.Forms.TableLayoutPanel();
            this.rentGroupBox = new System.Windows.Forms.GroupBox();
            this.rentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.rentItemIdLabel = new System.Windows.Forms.Label();
            this.borrowerNameLabel = new System.Windows.Forms.Label();
            this.rentalDateLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.rentItemIdTextBox = new System.Windows.Forms.TextBox();
            this.borrowerNameTextBox = new System.Windows.Forms.TextBox();
            this.rentalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.rentButtonSpacerLabel = new System.Windows.Forms.Label();
            this.rentButton = new System.Windows.Forms.Button();
            this.returnGroupBox = new System.Windows.Forms.GroupBox();
            this.returnLayout = new System.Windows.Forms.TableLayoutPanel();
            this.returnItemIdLabel = new System.Windows.Forms.Label();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.returnItemIdTextBox = new System.Windows.Forms.TextBox();
            this.returnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.returnButtonSpacerLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.searchHistoryTabPage = new System.Windows.Forms.TabPage();
            this.searchHistorySplitContainer = new System.Windows.Forms.SplitContainer();
            this.borrowerGroupBox = new System.Windows.Forms.GroupBox();
            this.borrowerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.borrowerSearchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.borrowerKeywordLabel = new System.Windows.Forms.Label();
            this.borrowerKeywordTextBox = new System.Windows.Forms.TextBox();
            this.borrowerSearchButton = new System.Windows.Forms.Button();
            this.borrowerAllButton = new System.Windows.Forms.Button();
            this.borrowerGrid = new System.Windows.Forms.DataGridView();
            this.borrowerGridItemIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerGridItemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerGridCategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerGridBorrowerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerGridRentalDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerGridDueDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerGridAlertColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyGroupBox = new System.Windows.Forms.GroupBox();
            this.historyLayout = new System.Windows.Forms.TableLayoutPanel();
            this.historySearchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.historyItemIdLabel = new System.Windows.Forms.Label();
            this.historyItemIdTextBox = new System.Windows.Forms.TextBox();
            this.historySearchButton = new System.Windows.Forms.Button();
            this.historyGrid = new System.Windows.Forms.DataGridView();
            this.historyGridRecordIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyGridBorrowerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyGridRentalDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyGridDueDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyGridReturnDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyGridStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusLabel = new System.Windows.Forms.Label();
            this.rootLayout.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.headerLayout.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.itemListTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.itemGridContextMenuStrip.SuspendLayout();
            this.registerTabPage.SuspendLayout();
            this.registerLayout.SuspendLayout();
            this.registerButtonPanel.SuspendLayout();
            this.rentReturnTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentReturnSplitContainer)).BeginInit();
            this.rentReturnSplitContainer.Panel1.SuspendLayout();
            this.rentReturnSplitContainer.Panel2.SuspendLayout();
            this.rentReturnSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemGrid)).BeginInit();
            this.rentReturnBottomLayout.SuspendLayout();
            this.rentGroupBox.SuspendLayout();
            this.rentLayout.SuspendLayout();
            this.returnGroupBox.SuspendLayout();
            this.returnLayout.SuspendLayout();
            this.searchHistoryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchHistorySplitContainer)).BeginInit();
            this.searchHistorySplitContainer.Panel1.SuspendLayout();
            this.searchHistorySplitContainer.Panel2.SuspendLayout();
            this.searchHistorySplitContainer.SuspendLayout();
            this.borrowerGroupBox.SuspendLayout();
            this.borrowerLayout.SuspendLayout();
            this.borrowerSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerGrid)).BeginInit();
            this.historyGroupBox.SuspendLayout();
            this.historyLayout.SuspendLayout();
            this.historySearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // rootLayout
            // 
            this.rootLayout.ColumnCount = 1;
            this.rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayout.Controls.Add(this.headerPanel, 0, 0);
            this.rootLayout.Controls.Add(this.mainTabControl, 0, 1);
            this.rootLayout.Controls.Add(this.statusLabel, 0, 2);
            this.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayout.Location = new System.Drawing.Point(0, 0);
            this.rootLayout.Name = "rootLayout";
            this.rootLayout.RowCount = 3;
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.rootLayout.Size = new System.Drawing.Size(1084, 681);
            this.rootLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.headerLayout);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(12, 8, 12, 4);
            this.headerPanel.Size = new System.Drawing.Size(1078, 54);
            this.headerPanel.TabIndex = 0;
            // 
            // headerLayout
            // 
            this.headerLayout.ColumnCount = 2;
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.headerLayout.Controls.Add(this.titleLabel, 0, 0);
            this.headerLayout.Controls.Add(this.refreshButton, 1, 0);
            this.headerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayout.Location = new System.Drawing.Point(12, 8);
            this.headerLayout.Name = "headerLayout";
            this.headerLayout.RowCount = 1;
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.Size = new System.Drawing.Size(1054, 42);
            this.headerLayout.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(928, 42);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "備品貸出管理システム";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // refreshButton
            // 
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshButton.Location = new System.Drawing.Point(934, 3);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(120, 36);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "更新";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.itemListTabPage);
            this.mainTabControl.Controls.Add(this.registerTabPage);
            this.mainTabControl.Controls.Add(this.rentReturnTabPage);
            this.mainTabControl.Controls.Add(this.searchHistoryTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(3, 63);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1078, 587);
            this.mainTabControl.TabIndex = 1;
            // 
            // itemListTabPage
            // 
            this.itemListTabPage.Controls.Add(this.itemGrid);
            this.itemListTabPage.Location = new System.Drawing.Point(4, 29);
            this.itemListTabPage.Name = "itemListTabPage";
            this.itemListTabPage.Padding = new System.Windows.Forms.Padding(8);
            this.itemListTabPage.Size = new System.Drawing.Size(1070, 554);
            this.itemListTabPage.TabIndex = 0;
            this.itemListTabPage.Text = "備品一覧";
            this.itemListTabPage.UseVisualStyleBackColor = true;
            // 
            // itemGrid
            // 
            this.itemGrid.AllowUserToAddRows = false;
            this.itemGrid.AllowUserToDeleteRows = false;
            this.itemGrid.AllowUserToResizeRows = false;
            this.itemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemGridItemIdColumn,
            this.itemGridItemNameColumn,
            this.itemGridCategoryColumn,
            this.itemGridStatusColumn,
            this.itemGridBorrowerColumn,
            this.itemGridRentalDateColumn,
            this.itemGridDueDateColumn,
            this.itemGridAlertColumn});
            this.itemGrid.ContextMenuStrip = this.itemGridContextMenuStrip;
            this.itemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemGrid.Location = new System.Drawing.Point(8, 8);
            this.itemGrid.MultiSelect = false;
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.ReadOnly = true;
            this.itemGrid.RowHeadersVisible = false;
            this.itemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGrid.Size = new System.Drawing.Size(1054, 538);
            this.itemGrid.TabIndex = 0;
            this.itemGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemGrid_CellDoubleClick);
            this.itemGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ItemGrid_CellMouseDown);
            this.itemGrid.SelectionChanged += new System.EventHandler(this.ItemGrid_SelectionChanged);
            // 
            // itemGridItemIdColumn
            // 
            this.itemGridItemIdColumn.HeaderText = "備品ID";
            this.itemGridItemIdColumn.MinimumWidth = 80;
            this.itemGridItemIdColumn.Name = "itemGridItemIdColumn";
            this.itemGridItemIdColumn.ReadOnly = true;
            // 
            // itemGridItemNameColumn
            // 
            this.itemGridItemNameColumn.HeaderText = "備品名";
            this.itemGridItemNameColumn.MinimumWidth = 80;
            this.itemGridItemNameColumn.Name = "itemGridItemNameColumn";
            this.itemGridItemNameColumn.ReadOnly = true;
            // 
            // itemGridCategoryColumn
            // 
            this.itemGridCategoryColumn.HeaderText = "区分";
            this.itemGridCategoryColumn.MinimumWidth = 80;
            this.itemGridCategoryColumn.Name = "itemGridCategoryColumn";
            this.itemGridCategoryColumn.ReadOnly = true;
            // 
            // itemGridStatusColumn
            // 
            this.itemGridStatusColumn.HeaderText = "状態";
            this.itemGridStatusColumn.MinimumWidth = 80;
            this.itemGridStatusColumn.Name = "itemGridStatusColumn";
            this.itemGridStatusColumn.ReadOnly = true;
            // 
            // itemGridBorrowerColumn
            // 
            this.itemGridBorrowerColumn.HeaderText = "借主";
            this.itemGridBorrowerColumn.MinimumWidth = 80;
            this.itemGridBorrowerColumn.Name = "itemGridBorrowerColumn";
            this.itemGridBorrowerColumn.ReadOnly = true;
            // 
            // itemGridRentalDateColumn
            // 
            this.itemGridRentalDateColumn.HeaderText = "貸出日";
            this.itemGridRentalDateColumn.MinimumWidth = 80;
            this.itemGridRentalDateColumn.Name = "itemGridRentalDateColumn";
            this.itemGridRentalDateColumn.ReadOnly = true;
            // 
            // itemGridDueDateColumn
            // 
            this.itemGridDueDateColumn.HeaderText = "返却予定日";
            this.itemGridDueDateColumn.MinimumWidth = 80;
            this.itemGridDueDateColumn.Name = "itemGridDueDateColumn";
            this.itemGridDueDateColumn.ReadOnly = true;
            // 
            // itemGridAlertColumn
            // 
            this.itemGridAlertColumn.HeaderText = "督促";
            this.itemGridAlertColumn.MinimumWidth = 80;
            this.itemGridAlertColumn.Name = "itemGridAlertColumn";
            this.itemGridAlertColumn.ReadOnly = true;
            // 
            // itemGridContextMenuStrip
            // 
            this.itemGridContextMenuStrip.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemGridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemGridRentToolStripMenuItem,
            this.itemGridReturnToolStripMenuItem,
            this.itemGridBorrowerSearchToolStripMenuItem,
            this.itemGridHistoryToolStripMenuItem});
            this.itemGridContextMenuStrip.Name = "itemGridContextMenuStrip";
            this.itemGridContextMenuStrip.Size = new System.Drawing.Size(143, 100);
            this.itemGridContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ItemGridContextMenuStrip_Opening);
            // 
            // itemGridRentToolStripMenuItem
            // 
            this.itemGridRentToolStripMenuItem.Name = "itemGridRentToolStripMenuItem";
            this.itemGridRentToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.itemGridRentToolStripMenuItem.Text = "貸出";
            this.itemGridRentToolStripMenuItem.Click += new System.EventHandler(this.ItemGridRentToolStripMenuItem_Click);
            // 
            // itemGridReturnToolStripMenuItem
            // 
            this.itemGridReturnToolStripMenuItem.Name = "itemGridReturnToolStripMenuItem";
            this.itemGridReturnToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.itemGridReturnToolStripMenuItem.Text = "返却";
            this.itemGridReturnToolStripMenuItem.Click += new System.EventHandler(this.ItemGridReturnToolStripMenuItem_Click);
            // 
            // itemGridBorrowerSearchToolStripMenuItem
            // 
            this.itemGridBorrowerSearchToolStripMenuItem.Name = "itemGridBorrowerSearchToolStripMenuItem";
            this.itemGridBorrowerSearchToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.itemGridBorrowerSearchToolStripMenuItem.Text = "借主検索";
            this.itemGridBorrowerSearchToolStripMenuItem.Click += new System.EventHandler(this.ItemGridBorrowerSearchToolStripMenuItem_Click);
            // 
            // itemGridHistoryToolStripMenuItem
            // 
            this.itemGridHistoryToolStripMenuItem.Name = "itemGridHistoryToolStripMenuItem";
            this.itemGridHistoryToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.itemGridHistoryToolStripMenuItem.Text = "貸出履歴";
            this.itemGridHistoryToolStripMenuItem.Click += new System.EventHandler(this.ItemGridHistoryToolStripMenuItem_Click);
            // 
            // registerTabPage
            // 
            this.registerTabPage.Controls.Add(this.registerLayout);
            this.registerTabPage.Location = new System.Drawing.Point(4, 29);
            this.registerTabPage.Name = "registerTabPage";
            this.registerTabPage.Padding = new System.Windows.Forms.Padding(16);
            this.registerTabPage.Size = new System.Drawing.Size(1070, 554);
            this.registerTabPage.TabIndex = 1;
            this.registerTabPage.Text = "備品登録";
            this.registerTabPage.UseVisualStyleBackColor = true;
            // 
            // registerLayout
            // 
            this.registerLayout.AutoSize = true;
            this.registerLayout.ColumnCount = 2;
            this.registerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.registerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.registerLayout.Controls.Add(this.itemIdLabel, 0, 0);
            this.registerLayout.Controls.Add(this.itemNameLabel, 0, 1);
            this.registerLayout.Controls.Add(this.categoryLabel, 0, 2);
            this.registerLayout.Controls.Add(this.itemIdTextBox, 1, 0);
            this.registerLayout.Controls.Add(this.itemNameTextBox, 1, 1);
            this.registerLayout.Controls.Add(this.categoryComboBox, 1, 2);
            this.registerLayout.Controls.Add(this.registerButtonSpacerLabel, 0, 3);
            this.registerLayout.Controls.Add(this.registerButtonPanel, 1, 3);
            this.registerLayout.Controls.Add(this.registerNoteLabel, 1, 4);
            this.registerLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.registerLayout.Location = new System.Drawing.Point(16, 16);
            this.registerLayout.Name = "registerLayout";
            this.registerLayout.RowCount = 5;
            this.registerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.registerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.registerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.registerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.registerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.registerLayout.Size = new System.Drawing.Size(1038, 182);
            this.registerLayout.TabIndex = 0;
            // 
            // itemIdLabel
            // 
            this.itemIdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemIdLabel.Location = new System.Drawing.Point(0, 6);
            this.itemIdLabel.Margin = new System.Windows.Forms.Padding(0, 6, 8, 6);
            this.itemIdLabel.Name = "itemIdLabel";
            this.itemIdLabel.Size = new System.Drawing.Size(112, 24);
            this.itemIdLabel.TabIndex = 0;
            this.itemIdLabel.Text = "備品ID";
            this.itemIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemNameLabel.Location = new System.Drawing.Point(0, 42);
            this.itemNameLabel.Margin = new System.Windows.Forms.Padding(0, 6, 8, 6);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(112, 24);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "備品名";
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryLabel.Location = new System.Drawing.Point(0, 78);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(0, 6, 8, 6);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(112, 24);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "区分";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemIdTextBox
            // 
            this.itemIdTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemIdTextBox.Location = new System.Drawing.Point(120, 4);
            this.itemIdTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.itemIdTextBox.Name = "itemIdTextBox";
            this.itemIdTextBox.Size = new System.Drawing.Size(918, 28);
            this.itemIdTextBox.TabIndex = 3;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemNameTextBox.Location = new System.Drawing.Point(120, 40);
            this.itemNameTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(918, 28);
            this.itemNameTextBox.TabIndex = 4;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(120, 76);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(918, 28);
            this.categoryComboBox.TabIndex = 5;
            // 
            // registerButtonSpacerLabel
            // 
            this.registerButtonSpacerLabel.Location = new System.Drawing.Point(3, 108);
            this.registerButtonSpacerLabel.Name = "registerButtonSpacerLabel";
            this.registerButtonSpacerLabel.Size = new System.Drawing.Size(100, 23);
            this.registerButtonSpacerLabel.TabIndex = 6;
            // 
            // registerButtonPanel
            // 
            this.registerButtonPanel.AutoSize = true;
            this.registerButtonPanel.Controls.Add(this.registerButton);
            this.registerButtonPanel.Controls.Add(this.clearItemInputButton);
            this.registerButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerButtonPanel.Location = new System.Drawing.Point(120, 108);
            this.registerButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.registerButtonPanel.Name = "registerButtonPanel";
            this.registerButtonPanel.Size = new System.Drawing.Size(918, 42);
            this.registerButtonPanel.TabIndex = 7;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(3, 3);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(130, 36);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "登録";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // clearItemInputButton
            // 
            this.clearItemInputButton.Location = new System.Drawing.Point(139, 3);
            this.clearItemInputButton.Name = "clearItemInputButton";
            this.clearItemInputButton.Size = new System.Drawing.Size(140, 36);
            this.clearItemInputButton.TabIndex = 1;
            this.clearItemInputButton.Text = "入力クリア";
            this.clearItemInputButton.UseVisualStyleBackColor = true;
            this.clearItemInputButton.Click += new System.EventHandler(this.ClearItemInputButton_Click);
            // 
            // registerNoteLabel
            // 
            this.registerNoteLabel.AutoSize = true;
            this.registerNoteLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.registerNoteLabel.Location = new System.Drawing.Point(120, 162);
            this.registerNoteLabel.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.registerNoteLabel.Name = "registerNoteLabel";
            this.registerNoteLabel.Size = new System.Drawing.Size(343, 20);
            this.registerNoteLabel.TabIndex = 8;
            this.registerNoteLabel.Text = "備品IDは大文字小文字を区別せず重複不可です。";
            // 
            // rentReturnTabPage
            // 
            this.rentReturnTabPage.Controls.Add(this.rentReturnSplitContainer);
            this.rentReturnTabPage.Location = new System.Drawing.Point(4, 29);
            this.rentReturnTabPage.Name = "rentReturnTabPage";
            this.rentReturnTabPage.Padding = new System.Windows.Forms.Padding(8);
            this.rentReturnTabPage.Size = new System.Drawing.Size(1070, 554);
            this.rentReturnTabPage.TabIndex = 2;
            this.rentReturnTabPage.Text = "貸出・返却";
            this.rentReturnTabPage.UseVisualStyleBackColor = true;
            // 
            // rentReturnSplitContainer
            // 
            this.rentReturnSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentReturnSplitContainer.Location = new System.Drawing.Point(8, 8);
            this.rentReturnSplitContainer.Name = "rentReturnSplitContainer";
            this.rentReturnSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rentReturnSplitContainer.Panel1
            // 
            this.rentReturnSplitContainer.Panel1.Controls.Add(this.rentalItemGrid);
            // 
            // rentReturnSplitContainer.Panel2
            // 
            this.rentReturnSplitContainer.Panel2.Controls.Add(this.rentReturnBottomLayout);
            this.rentReturnSplitContainer.Size = new System.Drawing.Size(1054, 538);
            this.rentReturnSplitContainer.SplitterDistance = 283;
            this.rentReturnSplitContainer.TabIndex = 0;
            // 
            // rentalItemGrid
            // 
            this.rentalItemGrid.AllowUserToAddRows = false;
            this.rentalItemGrid.AllowUserToDeleteRows = false;
            this.rentalItemGrid.AllowUserToResizeRows = false;
            this.rentalItemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rentalItemGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.rentalItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentalItemGridItemIdColumn,
            this.rentalItemGridItemNameColumn,
            this.rentalItemGridCategoryColumn,
            this.rentalItemGridStatusColumn,
            this.rentalItemGridBorrowerColumn,
            this.rentalItemGridRentalDateColumn,
            this.rentalItemGridDueDateColumn,
            this.rentalItemGridAlertColumn});
            this.rentalItemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalItemGrid.Location = new System.Drawing.Point(0, 0);
            this.rentalItemGrid.MultiSelect = false;
            this.rentalItemGrid.Name = "rentalItemGrid";
            this.rentalItemGrid.ReadOnly = true;
            this.rentalItemGrid.RowHeadersVisible = false;
            this.rentalItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentalItemGrid.Size = new System.Drawing.Size(1054, 283);
            this.rentalItemGrid.TabIndex = 0;
            this.rentalItemGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentalItemGrid_CellDoubleClick);
            this.rentalItemGrid.SelectionChanged += new System.EventHandler(this.RentalItemGrid_SelectionChanged);
            // 
            // rentalItemGridItemIdColumn
            // 
            this.rentalItemGridItemIdColumn.HeaderText = "備品ID";
            this.rentalItemGridItemIdColumn.MinimumWidth = 80;
            this.rentalItemGridItemIdColumn.Name = "rentalItemGridItemIdColumn";
            this.rentalItemGridItemIdColumn.ReadOnly = true;
            // 
            // rentalItemGridItemNameColumn
            // 
            this.rentalItemGridItemNameColumn.HeaderText = "備品名";
            this.rentalItemGridItemNameColumn.MinimumWidth = 80;
            this.rentalItemGridItemNameColumn.Name = "rentalItemGridItemNameColumn";
            this.rentalItemGridItemNameColumn.ReadOnly = true;
            // 
            // rentalItemGridCategoryColumn
            // 
            this.rentalItemGridCategoryColumn.HeaderText = "区分";
            this.rentalItemGridCategoryColumn.MinimumWidth = 80;
            this.rentalItemGridCategoryColumn.Name = "rentalItemGridCategoryColumn";
            this.rentalItemGridCategoryColumn.ReadOnly = true;
            // 
            // rentalItemGridStatusColumn
            // 
            this.rentalItemGridStatusColumn.HeaderText = "状態";
            this.rentalItemGridStatusColumn.MinimumWidth = 80;
            this.rentalItemGridStatusColumn.Name = "rentalItemGridStatusColumn";
            this.rentalItemGridStatusColumn.ReadOnly = true;
            // 
            // rentalItemGridBorrowerColumn
            // 
            this.rentalItemGridBorrowerColumn.HeaderText = "借主";
            this.rentalItemGridBorrowerColumn.MinimumWidth = 80;
            this.rentalItemGridBorrowerColumn.Name = "rentalItemGridBorrowerColumn";
            this.rentalItemGridBorrowerColumn.ReadOnly = true;
            // 
            // rentalItemGridRentalDateColumn
            // 
            this.rentalItemGridRentalDateColumn.HeaderText = "貸出日";
            this.rentalItemGridRentalDateColumn.MinimumWidth = 80;
            this.rentalItemGridRentalDateColumn.Name = "rentalItemGridRentalDateColumn";
            this.rentalItemGridRentalDateColumn.ReadOnly = true;
            // 
            // rentalItemGridDueDateColumn
            // 
            this.rentalItemGridDueDateColumn.HeaderText = "返却予定日";
            this.rentalItemGridDueDateColumn.MinimumWidth = 80;
            this.rentalItemGridDueDateColumn.Name = "rentalItemGridDueDateColumn";
            this.rentalItemGridDueDateColumn.ReadOnly = true;
            // 
            // rentalItemGridAlertColumn
            // 
            this.rentalItemGridAlertColumn.HeaderText = "督促";
            this.rentalItemGridAlertColumn.MinimumWidth = 80;
            this.rentalItemGridAlertColumn.Name = "rentalItemGridAlertColumn";
            this.rentalItemGridAlertColumn.ReadOnly = true;
            // 
            // rentReturnBottomLayout
            // 
            this.rentReturnBottomLayout.ColumnCount = 2;
            this.rentReturnBottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rentReturnBottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rentReturnBottomLayout.Controls.Add(this.rentGroupBox, 0, 0);
            this.rentReturnBottomLayout.Controls.Add(this.returnGroupBox, 1, 0);
            this.rentReturnBottomLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentReturnBottomLayout.Location = new System.Drawing.Point(0, 0);
            this.rentReturnBottomLayout.Name = "rentReturnBottomLayout";
            this.rentReturnBottomLayout.RowCount = 1;
            this.rentReturnBottomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rentReturnBottomLayout.Size = new System.Drawing.Size(1054, 251);
            this.rentReturnBottomLayout.TabIndex = 0;
            // 
            // rentGroupBox
            // 
            this.rentGroupBox.Controls.Add(this.rentLayout);
            this.rentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentGroupBox.Location = new System.Drawing.Point(3, 3);
            this.rentGroupBox.Name = "rentGroupBox";
            this.rentGroupBox.Padding = new System.Windows.Forms.Padding(12);
            this.rentGroupBox.Size = new System.Drawing.Size(521, 245);
            this.rentGroupBox.TabIndex = 0;
            this.rentGroupBox.TabStop = false;
            this.rentGroupBox.Text = "貸出処理";
            // 
            // rentLayout
            // 
            this.rentLayout.AutoSize = true;
            this.rentLayout.ColumnCount = 2;
            this.rentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.rentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rentLayout.Controls.Add(this.rentItemIdLabel, 0, 0);
            this.rentLayout.Controls.Add(this.borrowerNameLabel, 0, 1);
            this.rentLayout.Controls.Add(this.rentalDateLabel, 0, 2);
            this.rentLayout.Controls.Add(this.dueDateLabel, 0, 3);
            this.rentLayout.Controls.Add(this.rentItemIdTextBox, 1, 0);
            this.rentLayout.Controls.Add(this.borrowerNameTextBox, 1, 1);
            this.rentLayout.Controls.Add(this.rentalDatePicker, 1, 2);
            this.rentLayout.Controls.Add(this.dueDatePicker, 1, 3);
            this.rentLayout.Controls.Add(this.rentButtonSpacerLabel, 0, 4);
            this.rentLayout.Controls.Add(this.rentButton, 1, 4);
            this.rentLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.rentLayout.Location = new System.Drawing.Point(12, 33);
            this.rentLayout.Name = "rentLayout";
            this.rentLayout.RowCount = 5;
            this.rentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rentLayout.Size = new System.Drawing.Size(497, 186);
            this.rentLayout.TabIndex = 0;
            // 
            // rentItemIdLabel
            // 
            this.rentItemIdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentItemIdLabel.Location = new System.Drawing.Point(0, 6);
            this.rentItemIdLabel.Margin = new System.Windows.Forms.Padding(0, 6, 8, 6);
            this.rentItemIdLabel.Name = "rentItemIdLabel";
            this.rentItemIdLabel.Size = new System.Drawing.Size(102, 24);
            this.rentItemIdLabel.TabIndex = 0;
            this.rentItemIdLabel.Text = "備品ID";
            this.rentItemIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // borrowerNameLabel
            // 
            this.borrowerNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowerNameLabel.Location = new System.Drawing.Point(0, 42);
            this.borrowerNameLabel.Margin = new System.Windows.Forms.Padding(0, 6, 8, 6);
            this.borrowerNameLabel.Name = "borrowerNameLabel";
            this.borrowerNameLabel.Size = new System.Drawing.Size(102, 24);
            this.borrowerNameLabel.TabIndex = 1;
            this.borrowerNameLabel.Text = "借主";
            this.borrowerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rentalDateLabel
            // 
            this.rentalDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalDateLabel.Location = new System.Drawing.Point(0, 78);
            this.rentalDateLabel.Margin = new System.Windows.Forms.Padding(0, 6, 8, 6);
            this.rentalDateLabel.Name = "rentalDateLabel";
            this.rentalDateLabel.Size = new System.Drawing.Size(102, 24);
            this.rentalDateLabel.TabIndex = 2;
            this.rentalDateLabel.Text = "貸出日";
            this.rentalDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dueDateLabel.Location = new System.Drawing.Point(0, 114);
            this.dueDateLabel.Margin = new System.Windows.Forms.Padding(0, 6, 8, 6);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(102, 24);
            this.dueDateLabel.TabIndex = 3;
            this.dueDateLabel.Text = "返却予定日";
            this.dueDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rentItemIdTextBox
            // 
            this.rentItemIdTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.rentItemIdTextBox.Location = new System.Drawing.Point(110, 4);
            this.rentItemIdTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.rentItemIdTextBox.Name = "rentItemIdTextBox";
            this.rentItemIdTextBox.Size = new System.Drawing.Size(387, 28);
            this.rentItemIdTextBox.TabIndex = 4;
            // 
            // borrowerNameTextBox
            // 
            this.borrowerNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.borrowerNameTextBox.Location = new System.Drawing.Point(110, 40);
            this.borrowerNameTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.borrowerNameTextBox.Name = "borrowerNameTextBox";
            this.borrowerNameTextBox.Size = new System.Drawing.Size(387, 28);
            this.borrowerNameTextBox.TabIndex = 5;
            // 
            // rentalDatePicker
            // 
            this.rentalDatePicker.CustomFormat = "yyyy/MM/dd";
            this.rentalDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentalDatePicker.Location = new System.Drawing.Point(110, 76);
            this.rentalDatePicker.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.rentalDatePicker.Name = "rentalDatePicker";
            this.rentalDatePicker.Size = new System.Drawing.Size(160, 28);
            this.rentalDatePicker.TabIndex = 6;
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.CustomFormat = "yyyy/MM/dd";
            this.dueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dueDatePicker.Location = new System.Drawing.Point(110, 112);
            this.dueDatePicker.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(160, 28);
            this.dueDatePicker.TabIndex = 7;
            // 
            // rentButtonSpacerLabel
            // 
            this.rentButtonSpacerLabel.Location = new System.Drawing.Point(3, 144);
            this.rentButtonSpacerLabel.Name = "rentButtonSpacerLabel";
            this.rentButtonSpacerLabel.Size = new System.Drawing.Size(100, 23);
            this.rentButtonSpacerLabel.TabIndex = 8;
            // 
            // rentButton
            // 
            this.rentButton.Location = new System.Drawing.Point(113, 147);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(140, 36);
            this.rentButton.TabIndex = 9;
            this.rentButton.Text = "貸出";
            this.rentButton.UseVisualStyleBackColor = true;
            this.rentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // returnGroupBox
            // 
            this.returnGroupBox.Controls.Add(this.returnLayout);
            this.returnGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnGroupBox.Location = new System.Drawing.Point(530, 3);
            this.returnGroupBox.Name = "returnGroupBox";
            this.returnGroupBox.Padding = new System.Windows.Forms.Padding(12);
            this.returnGroupBox.Size = new System.Drawing.Size(521, 245);
            this.returnGroupBox.TabIndex = 1;
            this.returnGroupBox.TabStop = false;
            this.returnGroupBox.Text = "返却処理";
            // 
            // returnLayout
            // 
            this.returnLayout.AutoSize = true;
            this.returnLayout.ColumnCount = 2;
            this.returnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.returnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.returnLayout.Controls.Add(this.returnItemIdLabel, 0, 0);
            this.returnLayout.Controls.Add(this.returnDateLabel, 0, 1);
            this.returnLayout.Controls.Add(this.returnItemIdTextBox, 1, 0);
            this.returnLayout.Controls.Add(this.returnDatePicker, 1, 1);
            this.returnLayout.Controls.Add(this.returnButtonSpacerLabel, 0, 2);
            this.returnLayout.Controls.Add(this.returnButton, 1, 2);
            this.returnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.returnLayout.Location = new System.Drawing.Point(12, 33);
            this.returnLayout.Name = "returnLayout";
            this.returnLayout.RowCount = 4;
            this.returnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.returnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.returnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.returnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.returnLayout.Size = new System.Drawing.Size(497, 114);
            this.returnLayout.TabIndex = 0;
            // 
            // returnItemIdLabel
            // 
            this.returnItemIdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnItemIdLabel.Location = new System.Drawing.Point(0, 6);
            this.returnItemIdLabel.Margin = new System.Windows.Forms.Padding(0, 6, 8, 6);
            this.returnItemIdLabel.Name = "returnItemIdLabel";
            this.returnItemIdLabel.Size = new System.Drawing.Size(102, 24);
            this.returnItemIdLabel.TabIndex = 0;
            this.returnItemIdLabel.Text = "備品ID";
            this.returnItemIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnDateLabel.Location = new System.Drawing.Point(0, 42);
            this.returnDateLabel.Margin = new System.Windows.Forms.Padding(0, 6, 8, 6);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(102, 24);
            this.returnDateLabel.TabIndex = 1;
            this.returnDateLabel.Text = "返却日";
            this.returnDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // returnItemIdTextBox
            // 
            this.returnItemIdTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.returnItemIdTextBox.Location = new System.Drawing.Point(110, 4);
            this.returnItemIdTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.returnItemIdTextBox.Name = "returnItemIdTextBox";
            this.returnItemIdTextBox.Size = new System.Drawing.Size(387, 28);
            this.returnItemIdTextBox.TabIndex = 2;
            // 
            // returnDatePicker
            // 
            this.returnDatePicker.CustomFormat = "yyyy/MM/dd";
            this.returnDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returnDatePicker.Location = new System.Drawing.Point(110, 40);
            this.returnDatePicker.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.returnDatePicker.Name = "returnDatePicker";
            this.returnDatePicker.Size = new System.Drawing.Size(160, 28);
            this.returnDatePicker.TabIndex = 3;
            // 
            // returnButtonSpacerLabel
            // 
            this.returnButtonSpacerLabel.Location = new System.Drawing.Point(3, 72);
            this.returnButtonSpacerLabel.Name = "returnButtonSpacerLabel";
            this.returnButtonSpacerLabel.Size = new System.Drawing.Size(100, 23);
            this.returnButtonSpacerLabel.TabIndex = 4;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(113, 75);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(140, 36);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "返却";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // searchHistoryTabPage
            // 
            this.searchHistoryTabPage.Controls.Add(this.searchHistorySplitContainer);
            this.searchHistoryTabPage.Location = new System.Drawing.Point(4, 29);
            this.searchHistoryTabPage.Name = "searchHistoryTabPage";
            this.searchHistoryTabPage.Padding = new System.Windows.Forms.Padding(8);
            this.searchHistoryTabPage.Size = new System.Drawing.Size(1070, 554);
            this.searchHistoryTabPage.TabIndex = 3;
            this.searchHistoryTabPage.Text = "検索・履歴";
            this.searchHistoryTabPage.UseVisualStyleBackColor = true;
            // 
            // searchHistorySplitContainer
            // 
            this.searchHistorySplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchHistorySplitContainer.Location = new System.Drawing.Point(8, 8);
            this.searchHistorySplitContainer.Name = "searchHistorySplitContainer";
            this.searchHistorySplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // searchHistorySplitContainer.Panel1
            // 
            this.searchHistorySplitContainer.Panel1.Controls.Add(this.borrowerGroupBox);
            // 
            // searchHistorySplitContainer.Panel2
            // 
            this.searchHistorySplitContainer.Panel2.Controls.Add(this.historyGroupBox);
            this.searchHistorySplitContainer.Size = new System.Drawing.Size(1054, 538);
            this.searchHistorySplitContainer.SplitterDistance = 263;
            this.searchHistorySplitContainer.TabIndex = 0;
            // 
            // borrowerGroupBox
            // 
            this.borrowerGroupBox.Controls.Add(this.borrowerLayout);
            this.borrowerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowerGroupBox.Location = new System.Drawing.Point(0, 0);
            this.borrowerGroupBox.Name = "borrowerGroupBox";
            this.borrowerGroupBox.Padding = new System.Windows.Forms.Padding(8);
            this.borrowerGroupBox.Size = new System.Drawing.Size(1054, 263);
            this.borrowerGroupBox.TabIndex = 0;
            this.borrowerGroupBox.TabStop = false;
            this.borrowerGroupBox.Text = "社員別貸出状況";
            // 
            // borrowerLayout
            // 
            this.borrowerLayout.ColumnCount = 1;
            this.borrowerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.borrowerLayout.Controls.Add(this.borrowerSearchPanel, 0, 0);
            this.borrowerLayout.Controls.Add(this.borrowerGrid, 0, 1);
            this.borrowerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowerLayout.Location = new System.Drawing.Point(8, 29);
            this.borrowerLayout.Name = "borrowerLayout";
            this.borrowerLayout.RowCount = 2;
            this.borrowerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.borrowerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.borrowerLayout.Size = new System.Drawing.Size(1038, 226);
            this.borrowerLayout.TabIndex = 0;
            // 
            // borrowerSearchPanel
            // 
            this.borrowerSearchPanel.Controls.Add(this.borrowerKeywordLabel);
            this.borrowerSearchPanel.Controls.Add(this.borrowerKeywordTextBox);
            this.borrowerSearchPanel.Controls.Add(this.borrowerSearchButton);
            this.borrowerSearchPanel.Controls.Add(this.borrowerAllButton);
            this.borrowerSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowerSearchPanel.Location = new System.Drawing.Point(3, 3);
            this.borrowerSearchPanel.Name = "borrowerSearchPanel";
            this.borrowerSearchPanel.Size = new System.Drawing.Size(1032, 42);
            this.borrowerSearchPanel.TabIndex = 0;
            // 
            // borrowerKeywordLabel
            // 
            this.borrowerKeywordLabel.AutoSize = true;
            this.borrowerKeywordLabel.Location = new System.Drawing.Point(3, 10);
            this.borrowerKeywordLabel.Margin = new System.Windows.Forms.Padding(3, 10, 6, 3);
            this.borrowerKeywordLabel.Name = "borrowerKeywordLabel";
            this.borrowerKeywordLabel.Size = new System.Drawing.Size(103, 20);
            this.borrowerKeywordLabel.TabIndex = 0;
            this.borrowerKeywordLabel.Text = "借主キーワード";
            this.borrowerKeywordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // borrowerKeywordTextBox
            // 
            this.borrowerKeywordTextBox.Location = new System.Drawing.Point(115, 3);
            this.borrowerKeywordTextBox.Name = "borrowerKeywordTextBox";
            this.borrowerKeywordTextBox.Size = new System.Drawing.Size(240, 28);
            this.borrowerKeywordTextBox.TabIndex = 1;
            this.borrowerKeywordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BorrowerKeywordTextBox_KeyDown);
            // 
            // borrowerSearchButton
            // 
            this.borrowerSearchButton.Location = new System.Drawing.Point(361, 3);
            this.borrowerSearchButton.Name = "borrowerSearchButton";
            this.borrowerSearchButton.Size = new System.Drawing.Size(110, 36);
            this.borrowerSearchButton.TabIndex = 2;
            this.borrowerSearchButton.Text = "検索";
            this.borrowerSearchButton.UseVisualStyleBackColor = true;
            this.borrowerSearchButton.Click += new System.EventHandler(this.BorrowerSearchButton_Click);
            // 
            // borrowerAllButton
            // 
            this.borrowerAllButton.Location = new System.Drawing.Point(477, 3);
            this.borrowerAllButton.Name = "borrowerAllButton";
            this.borrowerAllButton.Size = new System.Drawing.Size(150, 36);
            this.borrowerAllButton.TabIndex = 3;
            this.borrowerAllButton.Text = "貸出中すべて";
            this.borrowerAllButton.UseVisualStyleBackColor = true;
            this.borrowerAllButton.Click += new System.EventHandler(this.BorrowerAllButton_Click);
            // 
            // borrowerGrid
            // 
            this.borrowerGrid.AllowUserToAddRows = false;
            this.borrowerGrid.AllowUserToDeleteRows = false;
            this.borrowerGrid.AllowUserToResizeRows = false;
            this.borrowerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.borrowerGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.borrowerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowerGridItemIdColumn,
            this.borrowerGridItemNameColumn,
            this.borrowerGridCategoryColumn,
            this.borrowerGridBorrowerColumn,
            this.borrowerGridRentalDateColumn,
            this.borrowerGridDueDateColumn,
            this.borrowerGridAlertColumn});
            this.borrowerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowerGrid.Location = new System.Drawing.Point(3, 51);
            this.borrowerGrid.MultiSelect = false;
            this.borrowerGrid.Name = "borrowerGrid";
            this.borrowerGrid.ReadOnly = true;
            this.borrowerGrid.RowHeadersVisible = false;
            this.borrowerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.borrowerGrid.Size = new System.Drawing.Size(1032, 172);
            this.borrowerGrid.TabIndex = 1;
            // 
            // borrowerGridItemIdColumn
            // 
            this.borrowerGridItemIdColumn.HeaderText = "備品ID";
            this.borrowerGridItemIdColumn.MinimumWidth = 80;
            this.borrowerGridItemIdColumn.Name = "borrowerGridItemIdColumn";
            this.borrowerGridItemIdColumn.ReadOnly = true;
            // 
            // borrowerGridItemNameColumn
            // 
            this.borrowerGridItemNameColumn.HeaderText = "備品名";
            this.borrowerGridItemNameColumn.MinimumWidth = 80;
            this.borrowerGridItemNameColumn.Name = "borrowerGridItemNameColumn";
            this.borrowerGridItemNameColumn.ReadOnly = true;
            // 
            // borrowerGridCategoryColumn
            // 
            this.borrowerGridCategoryColumn.HeaderText = "区分";
            this.borrowerGridCategoryColumn.MinimumWidth = 80;
            this.borrowerGridCategoryColumn.Name = "borrowerGridCategoryColumn";
            this.borrowerGridCategoryColumn.ReadOnly = true;
            // 
            // borrowerGridBorrowerColumn
            // 
            this.borrowerGridBorrowerColumn.HeaderText = "借主";
            this.borrowerGridBorrowerColumn.MinimumWidth = 80;
            this.borrowerGridBorrowerColumn.Name = "borrowerGridBorrowerColumn";
            this.borrowerGridBorrowerColumn.ReadOnly = true;
            // 
            // borrowerGridRentalDateColumn
            // 
            this.borrowerGridRentalDateColumn.HeaderText = "貸出日";
            this.borrowerGridRentalDateColumn.MinimumWidth = 80;
            this.borrowerGridRentalDateColumn.Name = "borrowerGridRentalDateColumn";
            this.borrowerGridRentalDateColumn.ReadOnly = true;
            // 
            // borrowerGridDueDateColumn
            // 
            this.borrowerGridDueDateColumn.HeaderText = "返却予定日";
            this.borrowerGridDueDateColumn.MinimumWidth = 80;
            this.borrowerGridDueDateColumn.Name = "borrowerGridDueDateColumn";
            this.borrowerGridDueDateColumn.ReadOnly = true;
            // 
            // borrowerGridAlertColumn
            // 
            this.borrowerGridAlertColumn.HeaderText = "督促";
            this.borrowerGridAlertColumn.MinimumWidth = 80;
            this.borrowerGridAlertColumn.Name = "borrowerGridAlertColumn";
            this.borrowerGridAlertColumn.ReadOnly = true;
            // 
            // historyGroupBox
            // 
            this.historyGroupBox.Controls.Add(this.historyLayout);
            this.historyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyGroupBox.Location = new System.Drawing.Point(0, 0);
            this.historyGroupBox.Name = "historyGroupBox";
            this.historyGroupBox.Padding = new System.Windows.Forms.Padding(8);
            this.historyGroupBox.Size = new System.Drawing.Size(1054, 271);
            this.historyGroupBox.TabIndex = 0;
            this.historyGroupBox.TabStop = false;
            this.historyGroupBox.Text = "備品別貸出履歴";
            // 
            // historyLayout
            // 
            this.historyLayout.ColumnCount = 1;
            this.historyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.historyLayout.Controls.Add(this.historySearchPanel, 0, 0);
            this.historyLayout.Controls.Add(this.historyGrid, 0, 1);
            this.historyLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyLayout.Location = new System.Drawing.Point(8, 29);
            this.historyLayout.Name = "historyLayout";
            this.historyLayout.RowCount = 2;
            this.historyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.historyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.historyLayout.Size = new System.Drawing.Size(1038, 234);
            this.historyLayout.TabIndex = 0;
            // 
            // historySearchPanel
            // 
            this.historySearchPanel.Controls.Add(this.historyItemIdLabel);
            this.historySearchPanel.Controls.Add(this.historyItemIdTextBox);
            this.historySearchPanel.Controls.Add(this.historySearchButton);
            this.historySearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historySearchPanel.Location = new System.Drawing.Point(3, 3);
            this.historySearchPanel.Name = "historySearchPanel";
            this.historySearchPanel.Size = new System.Drawing.Size(1032, 42);
            this.historySearchPanel.TabIndex = 0;
            // 
            // historyItemIdLabel
            // 
            this.historyItemIdLabel.AutoSize = true;
            this.historyItemIdLabel.Location = new System.Drawing.Point(3, 10);
            this.historyItemIdLabel.Margin = new System.Windows.Forms.Padding(3, 10, 6, 3);
            this.historyItemIdLabel.Name = "historyItemIdLabel";
            this.historyItemIdLabel.Size = new System.Drawing.Size(59, 20);
            this.historyItemIdLabel.TabIndex = 0;
            this.historyItemIdLabel.Text = "備品ID";
            this.historyItemIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // historyItemIdTextBox
            // 
            this.historyItemIdTextBox.Location = new System.Drawing.Point(71, 3);
            this.historyItemIdTextBox.Name = "historyItemIdTextBox";
            this.historyItemIdTextBox.Size = new System.Drawing.Size(180, 28);
            this.historyItemIdTextBox.TabIndex = 1;
            this.historyItemIdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HistoryItemIdTextBox_KeyDown);
            // 
            // historySearchButton
            // 
            this.historySearchButton.Location = new System.Drawing.Point(257, 3);
            this.historySearchButton.Name = "historySearchButton";
            this.historySearchButton.Size = new System.Drawing.Size(130, 36);
            this.historySearchButton.TabIndex = 2;
            this.historySearchButton.Text = "履歴表示";
            this.historySearchButton.UseVisualStyleBackColor = true;
            this.historySearchButton.Click += new System.EventHandler(this.HistorySearchButton_Click);
            // 
            // historyGrid
            // 
            this.historyGrid.AllowUserToAddRows = false;
            this.historyGrid.AllowUserToDeleteRows = false;
            this.historyGrid.AllowUserToResizeRows = false;
            this.historyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.historyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.historyGridRecordIdColumn,
            this.historyGridBorrowerColumn,
            this.historyGridRentalDateColumn,
            this.historyGridDueDateColumn,
            this.historyGridReturnDateColumn,
            this.historyGridStatusColumn});
            this.historyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyGrid.Location = new System.Drawing.Point(3, 51);
            this.historyGrid.MultiSelect = false;
            this.historyGrid.Name = "historyGrid";
            this.historyGrid.ReadOnly = true;
            this.historyGrid.RowHeadersVisible = false;
            this.historyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyGrid.Size = new System.Drawing.Size(1032, 180);
            this.historyGrid.TabIndex = 1;
            // 
            // historyGridRecordIdColumn
            // 
            this.historyGridRecordIdColumn.HeaderText = "記録ID";
            this.historyGridRecordIdColumn.MinimumWidth = 80;
            this.historyGridRecordIdColumn.Name = "historyGridRecordIdColumn";
            this.historyGridRecordIdColumn.ReadOnly = true;
            // 
            // historyGridBorrowerColumn
            // 
            this.historyGridBorrowerColumn.HeaderText = "借主";
            this.historyGridBorrowerColumn.MinimumWidth = 80;
            this.historyGridBorrowerColumn.Name = "historyGridBorrowerColumn";
            this.historyGridBorrowerColumn.ReadOnly = true;
            // 
            // historyGridRentalDateColumn
            // 
            this.historyGridRentalDateColumn.HeaderText = "貸出日";
            this.historyGridRentalDateColumn.MinimumWidth = 80;
            this.historyGridRentalDateColumn.Name = "historyGridRentalDateColumn";
            this.historyGridRentalDateColumn.ReadOnly = true;
            // 
            // historyGridDueDateColumn
            // 
            this.historyGridDueDateColumn.HeaderText = "返却予定日";
            this.historyGridDueDateColumn.MinimumWidth = 80;
            this.historyGridDueDateColumn.Name = "historyGridDueDateColumn";
            this.historyGridDueDateColumn.ReadOnly = true;
            // 
            // historyGridReturnDateColumn
            // 
            this.historyGridReturnDateColumn.HeaderText = "返却日";
            this.historyGridReturnDateColumn.MinimumWidth = 80;
            this.historyGridReturnDateColumn.Name = "historyGridReturnDateColumn";
            this.historyGridReturnDateColumn.ReadOnly = true;
            // 
            // historyGridStatusColumn
            // 
            this.historyGridStatusColumn.HeaderText = "状態";
            this.historyGridStatusColumn.MinimumWidth = 80;
            this.historyGridStatusColumn.Name = "historyGridStatusColumn";
            this.historyGridStatusColumn.ReadOnly = true;
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Location = new System.Drawing.Point(3, 653);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.statusLabel.Size = new System.Drawing.Size(1078, 28);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.rootLayout);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinimumSize = new System.Drawing.Size(980, 640);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "備品貸出管理システム";
            this.rootLayout.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerLayout.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.itemListTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.itemGridContextMenuStrip.ResumeLayout(false);
            this.registerTabPage.ResumeLayout(false);
            this.registerTabPage.PerformLayout();
            this.registerLayout.ResumeLayout(false);
            this.registerLayout.PerformLayout();
            this.registerButtonPanel.ResumeLayout(false);
            this.rentReturnTabPage.ResumeLayout(false);
            this.rentReturnSplitContainer.Panel1.ResumeLayout(false);
            this.rentReturnSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentReturnSplitContainer)).EndInit();
            this.rentReturnSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemGrid)).EndInit();
            this.rentReturnBottomLayout.ResumeLayout(false);
            this.rentGroupBox.ResumeLayout(false);
            this.rentGroupBox.PerformLayout();
            this.rentLayout.ResumeLayout(false);
            this.rentLayout.PerformLayout();
            this.returnGroupBox.ResumeLayout(false);
            this.returnGroupBox.PerformLayout();
            this.returnLayout.ResumeLayout(false);
            this.returnLayout.PerformLayout();
            this.searchHistoryTabPage.ResumeLayout(false);
            this.searchHistorySplitContainer.Panel1.ResumeLayout(false);
            this.searchHistorySplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchHistorySplitContainer)).EndInit();
            this.searchHistorySplitContainer.ResumeLayout(false);
            this.borrowerGroupBox.ResumeLayout(false);
            this.borrowerLayout.ResumeLayout(false);
            this.borrowerSearchPanel.ResumeLayout(false);
            this.borrowerSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerGrid)).EndInit();
            this.historyGroupBox.ResumeLayout(false);
            this.historyLayout.ResumeLayout(false);
            this.historySearchPanel.ResumeLayout(false);
            this.historySearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage itemListTabPage;
        private System.Windows.Forms.DataGridView itemGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGridItemIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGridItemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGridCategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGridStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGridBorrowerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGridRentalDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGridDueDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGridAlertColumn;
        private System.Windows.Forms.TabPage registerTabPage;
        private System.Windows.Forms.TableLayoutPanel registerLayout;
        private System.Windows.Forms.Label itemIdLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox itemIdTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label registerButtonSpacerLabel;
        private System.Windows.Forms.FlowLayoutPanel registerButtonPanel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button clearItemInputButton;
        private System.Windows.Forms.Label registerNoteLabel;
        private System.Windows.Forms.TabPage rentReturnTabPage;
        private System.Windows.Forms.SplitContainer rentReturnSplitContainer;
        private System.Windows.Forms.DataGridView rentalItemGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalItemGridItemIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalItemGridItemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalItemGridCategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalItemGridStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalItemGridBorrowerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalItemGridRentalDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalItemGridDueDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalItemGridAlertColumn;
        private System.Windows.Forms.TableLayoutPanel rentReturnBottomLayout;
        private System.Windows.Forms.GroupBox rentGroupBox;
        private System.Windows.Forms.TableLayoutPanel rentLayout;
        private System.Windows.Forms.Label rentItemIdLabel;
        private System.Windows.Forms.Label borrowerNameLabel;
        private System.Windows.Forms.Label rentalDateLabel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.TextBox rentItemIdTextBox;
        private System.Windows.Forms.TextBox borrowerNameTextBox;
        private System.Windows.Forms.DateTimePicker rentalDatePicker;
        private System.Windows.Forms.DateTimePicker dueDatePicker;
        private System.Windows.Forms.Label rentButtonSpacerLabel;
        private System.Windows.Forms.Button rentButton;
        private System.Windows.Forms.GroupBox returnGroupBox;
        private System.Windows.Forms.TableLayoutPanel returnLayout;
        private System.Windows.Forms.Label returnItemIdLabel;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.TextBox returnItemIdTextBox;
        private System.Windows.Forms.DateTimePicker returnDatePicker;
        private System.Windows.Forms.Label returnButtonSpacerLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TabPage searchHistoryTabPage;
        private System.Windows.Forms.SplitContainer searchHistorySplitContainer;
        private System.Windows.Forms.GroupBox borrowerGroupBox;
        private System.Windows.Forms.TableLayoutPanel borrowerLayout;
        private System.Windows.Forms.FlowLayoutPanel borrowerSearchPanel;
        private System.Windows.Forms.Label borrowerKeywordLabel;
        private System.Windows.Forms.TextBox borrowerKeywordTextBox;
        private System.Windows.Forms.Button borrowerSearchButton;
        private System.Windows.Forms.Button borrowerAllButton;
        private System.Windows.Forms.DataGridView borrowerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerGridItemIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerGridItemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerGridCategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerGridBorrowerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerGridRentalDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerGridDueDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerGridAlertColumn;
        private System.Windows.Forms.GroupBox historyGroupBox;
        private System.Windows.Forms.TableLayoutPanel historyLayout;
        private System.Windows.Forms.FlowLayoutPanel historySearchPanel;
        private System.Windows.Forms.Label historyItemIdLabel;
        private System.Windows.Forms.TextBox historyItemIdTextBox;
        private System.Windows.Forms.Button historySearchButton;
        private System.Windows.Forms.DataGridView historyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyGridRecordIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyGridBorrowerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyGridRentalDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyGridDueDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyGridReturnDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyGridStatusColumn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ContextMenuStrip itemGridContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem itemGridRentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemGridReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemGridBorrowerSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemGridHistoryToolStripMenuItem;
    }
}
