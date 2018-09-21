namespace HotelSYS
{
    partial class frmAddRoomType
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
            this.grpRoomType = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtRate2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDescription2 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grpRoomType
            // 
            this.grpRoomType.Location = new System.Drawing.Point(79, 342);
            this.grpRoomType.Name = "grpRoomType";
            this.grpRoomType.Size = new System.Drawing.Size(272, 135);
            this.grpRoomType.TabIndex = 15;
            this.grpRoomType.TabStop = false;
            this.grpRoomType.Text = "Enter Group Type Details";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(140, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Room Type";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(152, 182);
            this.txtRate.MaxLength = 7;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(151, 20);
            this.txtRate.TabIndex = 13;
            this.txtRate.Text = "0.00";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRate2
            // 
            this.txtRate2.AutoSize = true;
            this.txtRate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate2.Location = new System.Drawing.Point(105, 182);
            this.txtRate2.Name = "txtRate2";
            this.txtRate2.Size = new System.Drawing.Size(37, 16);
            this.txtRate2.TabIndex = 12;
            this.txtRate2.Text = "Rate";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(152, 134);
            this.txtDescription.MaxLength = 20;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(151, 20);
            this.txtDescription.TabIndex = 11;
            // 
            // txtDescription2
            // 
            this.txtDescription2.AutoSize = true;
            this.txtDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription2.Location = new System.Drawing.Point(66, 134);
            this.txtDescription2.Name = "txtDescription2";
            this.txtDescription2.Size = new System.Drawing.Size(76, 16);
            this.txtDescription2.TabIndex = 10;
            this.txtDescription2.Text = "Description";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(152, 94);
            this.txtRoomType.MaxLength = 2;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(25, 20);
            this.txtRoomType.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Room Type";
            // 
            // frmAddRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 707);
            this.Controls.Add(this.grpRoomType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtRate2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDescription2);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.label1);
            this.Name = "frmAddRoomType";
            this.Text = "HotelSYS - Add Room Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRoomType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label txtRate2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label txtDescription2;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label label1;
    }
}