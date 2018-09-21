namespace HotelSYS
{
    partial class frmDate
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
            this.SuspendLayout();
            // 
            // calDateOfBirth
            // 
            this.calDateOfBirth.Location = new System.Drawing.Point(216, 122);
            this.calDateOfBirth.MaxDate = new System.DateTime(2018, 9, 21, 0, 0, 0, 0);
            this.calDateOfBirth.Name = "calDateOfBirth";
            this.calDateOfBirth.TabIndex = 0;
            // 
            // frmDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 538);
            this.Controls.Add(this.calDateOfBirth);
            this.Name = "frmDate";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calDateOfBirth;
    }
}