namespace WinFormsApp_Example
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.labelWriteTimer = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryOfBilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nayavnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAdditionalInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAdd = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSearch = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxSearch = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSellCar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveToFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDownloadTxt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveJson = new System.Windows.Forms.ToolStripButton();
            this.toolStripDownloadJson = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.labelWriteTimer);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.labelTimer);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(645, 340);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(645, 365);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // labelWriteTimer
            // 
            this.labelWriteTimer.AutoSize = true;
            this.labelWriteTimer.Location = new System.Drawing.Point(558, 316);
            this.labelWriteTimer.Name = "labelWriteTimer";
            this.labelWriteTimer.Size = new System.Drawing.Size(36, 15);
            this.labelWriteTimer.TabIndex = 8;
            this.labelWriteTimer.Text = "Time:";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(600, 316);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(13, 15);
            this.labelTimer.TabIndex = 7;
            this.labelTimer.Text = "0";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.CountryOfBilding,
            this.Nayavnost,
            this.getAdditionalInfoDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.CarBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(643, 340);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Марка авто";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameDataGridViewTextBoxColumn.Width = 69;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Модель авто";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.positionDataGridViewTextBoxColumn.Width = 75;
            // 
            // CountryOfBilding
            // 
            this.CountryOfBilding.DataPropertyName = "CountryOfBilding";
            this.CountryOfBilding.HeaderText = "Країна виробництва";
            this.CountryOfBilding.Name = "CountryOfBilding";
            this.CountryOfBilding.ReadOnly = true;
            // 
            // Nayavnost
            // 
            this.Nayavnost.DataPropertyName = "Nayavnost";
            this.Nayavnost.HeaderText = "Наявність";
            this.Nayavnost.Name = "Nayavnost";
            this.Nayavnost.ReadOnly = true;
            // 
            // getAdditionalInfoDataGridViewTextBoxColumn
            // 
            this.getAdditionalInfoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.getAdditionalInfoDataGridViewTextBoxColumn.DataPropertyName = "EngineVolume";
            this.getAdditionalInfoDataGridViewTextBoxColumn.HeaderText = "Обєм мотора";
            this.getAdditionalInfoDataGridViewTextBoxColumn.Name = "getAdditionalInfoDataGridViewTextBoxColumn";
            this.getAdditionalInfoDataGridViewTextBoxColumn.ReadOnly = true;
            this.getAdditionalInfoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.getAdditionalInfoDataGridViewTextBoxColumn.Width = 79;
            // 
            // CarBindingSource
            // 
            this.CarBindingSource.DataSource = typeof(WinFormsApp_Example.Car);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAdd,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSearch,
            this.toolStripComboBoxSearch,
            this.toolStripTextBoxSearch,
            this.toolStripSeparator2,
            this.toolStripButtonRefresh,
            this.toolStripSeparator3,
            this.toolStripButtonSellCar,
            this.toolStripButtonSaveToFile,
            this.toolStripButtonDownloadTxt,
            this.toolStripSaveJson,
            this.toolStripDownloadJson,
            this.toolStripButtonAbout});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(642, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripAdd
            // 
            this.toolStripAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripAdd.ForeColor = System.Drawing.Color.Black;
            this.toolStripAdd.Name = "toolStripAdd";
            this.toolStripAdd.Size = new System.Drawing.Size(46, 22);
            this.toolStripAdd.Text = "Додати";
            this.toolStripAdd.Click += new System.EventHandler(this.toolStripAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "Видалити";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.ForeColor = System.Drawing.Color.Black;
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(46, 22);
            this.toolStripSearch.Text = "Пошук";
            this.toolStripSearch.Click += new System.EventHandler(this.toolStripRemove_Click);
            // 
            // toolStripComboBoxSearch
            // 
            this.toolStripComboBoxSearch.Items.AddRange(new object[] {
            "Марка",
            "Країна виробництва",
            "Об\'єм мотора"});
            this.toolStripComboBoxSearch.Name = "toolStripComboBoxSearch";
            this.toolStripComboBoxSearch.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxSearch.Text = "Виберіть критерій";
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonRefresh.Text = "Обновить";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSellCar
            // 
            this.toolStripButtonSellCar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSellCar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSellCar.Name = "toolStripButtonSellCar";
            this.toolStripButtonSellCar.Size = new System.Drawing.Size(85, 22);
            this.toolStripButtonSellCar.Text = "Продати авто";
            this.toolStripButtonSellCar.Click += new System.EventHandler(this.toolStripButtonSellCar_Click);
            // 
            // toolStripButtonSaveToFile
            // 
            this.toolStripButtonSaveToFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSaveToFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveToFile.Name = "toolStripButtonSaveToFile";
            this.toolStripButtonSaveToFile.Size = new System.Drawing.Size(81, 19);
            this.toolStripButtonSaveToFile.Text = "Зберегти .txt";
            this.toolStripButtonSaveToFile.Click += new System.EventHandler(this.toolStripButtonSaveToFile_Click);
            // 
            // toolStripButtonDownloadTxt
            // 
            this.toolStripButtonDownloadTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDownloadTxt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDownloadTxt.Name = "toolStripButtonDownloadTxt";
            this.toolStripButtonDownloadTxt.Size = new System.Drawing.Size(86, 19);
            this.toolStripButtonDownloadTxt.Text = "Загрузити .txt";
            this.toolStripButtonDownloadTxt.Click += new System.EventHandler(this.toolStripButtonDownloadTxt_Click);
            // 
            // toolStripSaveJson
            // 
            this.toolStripSaveJson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSaveJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveJson.Name = "toolStripSaveJson";
            this.toolStripSaveJson.Size = new System.Drawing.Size(89, 19);
            this.toolStripSaveJson.Text = "Зберегти .json";
            this.toolStripSaveJson.Click += new System.EventHandler(this.toolStripSaveJson_Click);
            // 
            // toolStripDownloadJson
            // 
            this.toolStripDownloadJson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDownloadJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDownloadJson.Name = "toolStripDownloadJson";
            this.toolStripDownloadJson.Size = new System.Drawing.Size(94, 19);
            this.toolStripDownloadJson.Text = "Загрузити .json";
            this.toolStripDownloadJson.Click += new System.EventHandler(this.toolStripDownloadJson_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(44, 19);
            this.toolStripButtonAbout.Text = "About";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 365);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автосалон";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private ToolStripContainer toolStripContainer1;
		private ToolStrip toolStrip1;
		private ToolStripLabel toolStripAdd;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripLabel toolStripSearch;
		private BindingSource CarBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CountryOfBilding;
        private DataGridViewTextBoxColumn Nayavnost;
        private DataGridViewTextBoxColumn getAdditionalInfoDataGridViewTextBoxColumn;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox toolStripComboBoxSearch;
        private ToolStripTextBox toolStripTextBoxSearch;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonRefresh;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButtonSellCar;
        private ToolStripButton toolStripButtonSaveToFile;
        private ToolStripButton toolStripButtonDownloadTxt;
        private ToolStripButton toolStripSaveJson;
        private ToolStripButton toolStripDownloadJson;
        private ToolStripButton toolStripButtonAbout;
        private Label labelWriteTimer;
        private Label labelTimer;
        public DataGridView dataGridView;
        private System.Windows.Forms.Timer timer1;
    }
}