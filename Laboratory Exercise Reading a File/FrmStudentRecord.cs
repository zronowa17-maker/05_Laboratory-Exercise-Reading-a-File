using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Exercise_Reading_a_File
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
           
         
            lvStudentData.Items.Clear();

        
            MessageBox.Show("Successfully Uploaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            lvStudentData.Items.Clear();
            MessageBox.Show("Successfully Uploaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


