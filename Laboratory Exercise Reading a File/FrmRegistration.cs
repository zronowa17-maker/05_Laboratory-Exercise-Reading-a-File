using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Exercise_Reading_a_File
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmStudentRecord studentRecordForm = new FrmStudentRecord();
            studentRecordForm.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string studentNo = txtStudentNumber.Text;
            string program = cmbProgram.Text;
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string mi = txtMI.Text;
            string age = txtAge.Text;
            string gender = cmbGender.Text;
            string birthday = dtpBirthday.Value.ToShortDateString();
            string contactNo = txtContactNo.Text;

           
            if (string.IsNullOrWhiteSpace(studentNo))
            {
                MessageBox.Show("Student Number cannot be empty. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentNumber.Focus();
                return;
            }

            
            string dataLine = studentNo + "," + lastName + "," + firstName + "," + mi + "," + age + "," + gender + "," + program + "," + birthday + "," + contactNo;

            try
            {
                
                string folderPath = Application.StartupPath + @"\StudentRecords\";
                string fileName = studentNo + ".txt";
                string fullPath = folderPath + fileName;

                
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                
                File.WriteAllText(fullPath, dataLine);

               
                MessageBox.Show("Student Record SAVED successfully!\nFile Path: " + fullPath,
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Error saving record: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}













