namespace HotelSYS
{
    partial class frmDateTest
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
            this.calDateOfBirth = new System.Windows.Forms.MonthCalendar();
            this.chkGarden = new System.Windows.Forms.CheckBox();
            this.chkGarage = new System.Windows.Forms.CheckBox();
            this.chkSolar = new System.Windows.Forms.CheckBox();
            this.grGender = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.grMarriageStatus = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.coTest = new System.Windows.Forms.ComboBox();
            this.grGender.SuspendLayout();
            this.grMarriageStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // calDateOfBirth
            // 
            this.calDateOfBirth.Location = new System.Drawing.Point(18, 6);
            this.calDateOfBirth.MaxDate = new System.DateTime(2018, 9, 21, 0, 0, 0, 0);
            this.calDateOfBirth.Name = "calDateOfBirth";
            this.calDateOfBirth.TabIndex = 0;
            // 
            // chkGarden
            // 
            this.chkGarden.AutoSize = true;
            this.chkGarden.Location = new System.Drawing.Point(288, 31);
            this.chkGarden.Name = "chkGarden";
            this.chkGarden.Size = new System.Drawing.Size(61, 17);
            this.chkGarden.TabIndex = 1;
            this.chkGarden.Text = "Garden";
            this.chkGarden.UseVisualStyleBackColor = true;
            this.chkGarden.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkGarage
            // 
            this.chkGarage.AutoSize = true;
            this.chkGarage.Location = new System.Drawing.Point(288, 63);
            this.chkGarage.Name = "chkGarage";
            this.chkGarage.Size = new System.Drawing.Size(61, 17);
            this.chkGarage.TabIndex = 2;
            this.chkGarage.Text = "Garage";
            this.chkGarage.UseVisualStyleBackColor = true;
            // 
            // chkSolar
            // 
            this.chkSolar.AutoSize = true;
            this.chkSolar.Location = new System.Drawing.Point(288, 98);
            this.chkSolar.Name = "chkSolar";
            this.chkSolar.Size = new System.Drawing.Size(85, 17);
            this.chkSolar.TabIndex = 3;
            this.chkSolar.Text = "Solar Panels";
            this.chkSolar.UseVisualStyleBackColor = true;
            // 
            // grGender
            // 
            this.grGender.Controls.Add(this.radioButton2);
            this.grGender.Controls.Add(this.radioButton1);
            this.grGender.Location = new System.Drawing.Point(410, 31);
            this.grGender.Name = "grGender";
            this.grGender.Size = new System.Drawing.Size(157, 59);
            this.grGender.TabIndex = 8;
            this.grGender.TabStop = false;
            this.grGender.Text = "Gender";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Female";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(83, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Male";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // grMarriageStatus
            // 
            this.grMarriageStatus.Controls.Add(this.radioButton4);
            this.grMarriageStatus.Controls.Add(this.radioButton3);
            this.grMarriageStatus.Location = new System.Drawing.Point(410, 109);
            this.grMarriageStatus.Name = "grMarriageStatus";
            this.grMarriageStatus.Size = new System.Drawing.Size(141, 59);
            this.grMarriageStatus.TabIndex = 9;
            this.grMarriageStatus.TabStop = false;
            this.grMarriageStatus.Text = "Marriage Status";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 28);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Married";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(72, 28);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(54, 17);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.Text = "Single";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // coTest
            // 
            this.coTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coTest.FormattingEnabled = true;
            this.coTest.Items.AddRange(new object[] {
            "1. Hi",
            "2. Hello",
            "3. Howdy",
            "4. Bye"});
            this.coTest.Location = new System.Drawing.Point(605, 31);
            this.coTest.Name = "coTest";
            this.coTest.Size = new System.Drawing.Size(152, 21);
            this.coTest.TabIndex = 10;
            this.coTest.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmDateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.coTest);
            this.Controls.Add(this.grMarriageStatus);
            this.Controls.Add(this.grGender);
            this.Controls.Add(this.chkSolar);
            this.Controls.Add(this.chkGarage);
            this.Controls.Add(this.chkGarden);
            this.Controls.Add(this.calDateOfBirth);
            this.Name = "frmDateTest";
            this.Text = "frmDateTest";
            this.grGender.ResumeLayout(false);
            this.grGender.PerformLayout();
            this.grMarriageStatus.ResumeLayout(false);
            this.grMarriageStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calDateOfBirth;
        private System.Windows.Forms.CheckBox chkGarden;
        private System.Windows.Forms.CheckBox chkGarage;
        private System.Windows.Forms.CheckBox chkSolar;
        private System.Windows.Forms.GroupBox grGender;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grMarriageStatus;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox coTest;
    }
}