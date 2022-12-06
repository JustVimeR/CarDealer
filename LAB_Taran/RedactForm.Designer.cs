namespace WinFormsApp_CarDealer
{
    partial class RedactForm
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
            this.textBoxFBrand = new System.Windows.Forms.TextBox();
            this.textBoxFModel = new System.Windows.Forms.TextBox();
            this.textBoxFCountry = new System.Windows.Forms.TextBox();
            this.textBoxFMotor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFNayavnost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFBrand
            // 
            this.textBoxFBrand.Location = new System.Drawing.Point(173, 12);
            this.textBoxFBrand.Name = "textBoxFBrand";
            this.textBoxFBrand.Size = new System.Drawing.Size(144, 23);
            this.textBoxFBrand.TabIndex = 0;
            // 
            // textBoxFModel
            // 
            this.textBoxFModel.Location = new System.Drawing.Point(173, 50);
            this.textBoxFModel.Name = "textBoxFModel";
            this.textBoxFModel.Size = new System.Drawing.Size(144, 23);
            this.textBoxFModel.TabIndex = 1;
            // 
            // textBoxFCountry
            // 
            this.textBoxFCountry.Location = new System.Drawing.Point(173, 91);
            this.textBoxFCountry.Name = "textBoxFCountry";
            this.textBoxFCountry.Size = new System.Drawing.Size(144, 23);
            this.textBoxFCountry.TabIndex = 2;
            // 
            // textBoxFMotor
            // 
            this.textBoxFMotor.Location = new System.Drawing.Point(173, 131);
            this.textBoxFMotor.Name = "textBoxFMotor";
            this.textBoxFMotor.Size = new System.Drawing.Size(144, 23);
            this.textBoxFMotor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Країна виробництва";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Обєм мотра";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFNayavnost
            // 
            this.textBoxFNayavnost.Location = new System.Drawing.Point(173, 169);
            this.textBoxFNayavnost.Name = "textBoxFNayavnost";
            this.textBoxFNayavnost.Size = new System.Drawing.Size(144, 23);
            this.textBoxFNayavnost.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Статус";
            // 
            // RedactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 289);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFNayavnost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFMotor);
            this.Controls.Add(this.textBoxFCountry);
            this.Controls.Add(this.textBoxFModel);
            this.Controls.Add(this.textBoxFBrand);
            this.Name = "RedactForm";
            this.Text = "Редагування";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        public TextBox textBoxFBrand;
        public TextBox textBoxFModel;
        public TextBox textBoxFCountry;
        public TextBox textBoxFMotor;
        public TextBox textBoxFNayavnost;
        private Label label5;
    }
}