namespace WinFormsApp_Example
{
	partial class FormAddNewCar
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxCarType = new System.Windows.Forms.ComboBox();
            this.labelExperienceYears = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ModelOfAuto = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxFuelCons = new System.Windows.Forms.TextBox();
            this.textBoxCountryOfBilding = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(8, 8);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxCarType
            // 
            this.comboBoxCarType.FormattingEnabled = true;
            this.comboBoxCarType.Items.AddRange(new object[] {
            "В наявності",
            "Нема в наявності"});
            this.comboBoxCarType.Location = new System.Drawing.Point(158, 8);
            this.comboBoxCarType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCarType.Name = "comboBoxCarType";
            this.comboBoxCarType.Size = new System.Drawing.Size(180, 23);
            this.comboBoxCarType.TabIndex = 2;
            // 
            // labelExperienceYears
            // 
            this.labelExperienceYears.AutoSize = true;
            this.labelExperienceYears.Location = new System.Drawing.Point(10, 82);
            this.labelExperienceYears.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExperienceYears.Name = "labelExperienceYears";
            this.labelExperienceYears.Size = new System.Drawing.Size(93, 15);
            this.labelExperienceYears.TabIndex = 11;
            this.labelExperienceYears.Text = "Витрати палива";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(10, 109);
            this.labelLanguage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(100, 15);
            this.labelLanguage.TabIndex = 10;
            this.labelLanguage.Text = "Країна виробник";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 28);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 15);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Марка";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ModelOfAuto);
            this.groupBox1.Controls.Add(this.textBoxModel);
            this.groupBox1.Controls.Add(this.textBoxFuelCons);
            this.groupBox1.Controls.Add(this.labelExperienceYears);
            this.groupBox1.Controls.Add(this.textBoxCountryOfBilding);
            this.groupBox1.Controls.Add(this.textBoxBrand);
            this.groupBox1.Controls.Add(this.labelLanguage);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(8, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(342, 143);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // ModelOfAuto
            // 
            this.ModelOfAuto.AutoSize = true;
            this.ModelOfAuto.Location = new System.Drawing.Point(10, 55);
            this.ModelOfAuto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModelOfAuto.Name = "ModelOfAuto";
            this.ModelOfAuto.Size = new System.Drawing.Size(50, 15);
            this.ModelOfAuto.TabIndex = 19;
            this.ModelOfAuto.Text = "Модель";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(149, 47);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(180, 23);
            this.textBoxModel.TabIndex = 18;
            // 
            // textBoxFuelCons
            // 
            this.textBoxFuelCons.Location = new System.Drawing.Point(149, 74);
            this.textBoxFuelCons.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFuelCons.Name = "textBoxFuelCons";
            this.textBoxFuelCons.Size = new System.Drawing.Size(180, 23);
            this.textBoxFuelCons.TabIndex = 17;
            // 
            // textBoxCountryOfBilding
            // 
            this.textBoxCountryOfBilding.Location = new System.Drawing.Point(150, 101);
            this.textBoxCountryOfBilding.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCountryOfBilding.Name = "textBoxCountryOfBilding";
            this.textBoxCountryOfBilding.Size = new System.Drawing.Size(180, 23);
            this.textBoxCountryOfBilding.TabIndex = 16;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(149, 20);
            this.textBoxBrand.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(180, 23);
            this.textBoxBrand.TabIndex = 15;
            // 
            // FormAddNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(359, 181);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxCarType);
            this.Controls.Add(this.buttonAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "FormAddNewCar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Нове авто";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private Button buttonAdd;
		private ComboBox comboBoxCarType;
		private Label labelExperienceYears;
		private Label labelLanguage;
		private Label labelName;
		private GroupBox groupBox1;
		private TextBox textBoxFuelCons;
		private TextBox textBoxCountryOfBilding;
		private TextBox textBoxBrand;
        private Label ModelOfAuto;
        private TextBox textBoxModel;
    }
}