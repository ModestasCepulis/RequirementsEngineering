namespace HotelSYS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.picMainMenu = new System.Windows.Forms.PictureBox();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReservations = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddRoomType = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRoomTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeRoom = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMainMenu
            // 
            this.picMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMainMenu.Image")));
            this.picMainMenu.Location = new System.Drawing.Point(147, 167);
            this.picMainMenu.Name = "picMainMenu";
            this.picMainMenu.Size = new System.Drawing.Size(502, 381);
            this.picMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainMenu.TabIndex = 0;
            this.picMainMenu.TabStop = false;
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRooms,
            this.mnuReservations,
            this.mnuAdmin,
            this.mnuExit});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(995, 24);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuRooms
            // 
            this.mnuRooms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddRoomType,
            this.changeRoomTypeToolStripMenuItem,
            this.mnuAddRoom,
            this.mnuChangeRoom});
            this.mnuRooms.Name = "mnuRooms";
            this.mnuRooms.Size = new System.Drawing.Size(56, 20);
            this.mnuRooms.Text = "Rooms";
            // 
            // mnuReservations
            // 
            this.mnuReservations.Name = "mnuReservations";
            this.mnuReservations.Size = new System.Drawing.Size(85, 20);
            this.mnuReservations.Text = "Reservations";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuAddRoomType
            // 
            this.mnuAddRoomType.Name = "mnuAddRoomType";
            this.mnuAddRoomType.Size = new System.Drawing.Size(180, 22);
            this.mnuAddRoomType.Text = "Add Room Type";
            // 
            // changeRoomTypeToolStripMenuItem
            // 
            this.changeRoomTypeToolStripMenuItem.Name = "changeRoomTypeToolStripMenuItem";
            this.changeRoomTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeRoomTypeToolStripMenuItem.Text = "Change Room Type";
            // 
            // mnuAddRoom
            // 
            this.mnuAddRoom.Name = "mnuAddRoom";
            this.mnuAddRoom.Size = new System.Drawing.Size(180, 22);
            this.mnuAddRoom.Text = "Add Room";
            // 
            // mnuChangeRoom
            // 
            this.mnuChangeRoom.Name = "mnuChangeRoom";
            this.mnuChangeRoom.Size = new System.Drawing.Size(180, 22);
            this.mnuChangeRoom.Text = "Change Room";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 709);
            this.Controls.Add(this.picMainMenu);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainMenu";
            this.Text = "HotelSYS - MainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMainMenu;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuRooms;
        private System.Windows.Forms.ToolStripMenuItem mnuReservations;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuAddRoomType;
        private System.Windows.Forms.ToolStripMenuItem changeRoomTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddRoom;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeRoom;
    }
}

