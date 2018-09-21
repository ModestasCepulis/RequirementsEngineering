using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSYS
{
    public partial class frmAddRoomType : Form
    {
        public frmAddRoomType()
        {
            InitializeComponent();
        }

        private void txtRate_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click1(object sender, EventArgs e)
        {
            //Validate Data Entered
            if(txtRoomType.Text.Equals(""))
            {
            MessageBox.Show("Room Type must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtRoomType.Focus();
            return;      
            }
            else if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("The Description must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }
            else if (txtRate.Text.Equals("0.00"))
            {
                MessageBox.Show("The rate must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                return;
            }


            //Save Data in Rates File

            //Display Confirmation Message
            MessageBox.Show("Room Type Added","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);

            //Reset UI
            txtRoomType.Clear();
            txtDescription.Clear();
            txtRate.Clear();
            txtRoomType.Focus();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //Validate Data Entered
            if (txtRoomType.Text.Equals(""))
            {
                MessageBox.Show("Room Type must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomType.Focus();
                return;
            }
            else if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("The Description must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }
            else if (txtRate.Text.Equals("0.00"))
            {
                MessageBox.Show("The rate must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                return;
            }


            //Save Data in Rates File

            //Display Confirmation Message
            MessageBox.Show("Room Type Added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtRoomType.Clear();
            txtDescription.Clear();
            txtRate.Clear();
            txtRoomType.Focus();


        }
    }
}
