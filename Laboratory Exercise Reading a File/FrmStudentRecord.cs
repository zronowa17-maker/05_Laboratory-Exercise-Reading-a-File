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
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration registrationForm = new FrmRegistration();
            registrationForm.Show();
            this.Hide();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

          
            lvStudentData.Items.Clear();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
              
                openFileDialog.Title = "Find Student Record File";
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

             
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                   
                        string[] lines = File.ReadAllLines(filePath);

                       
                        foreach (string line in lines)
                        {
                          
                            string[] parts = line.Split(',');

                          
                            ListViewItem item = new ListViewItem(parts[0]);

                           
                            for (int i = 1; i < parts.Length; i++)
                            {
                                item.SubItems.Add(parts[i]);
                            }

                         
                            lvStudentData.Items.Add(item);
                        }

                        
                        MessageBox.Show("File found and data loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error reading file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("File search cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    

        private void btnUpload_Click(object sender, EventArgs e)
        {

            lvStudentData.Items.Clear();
            MessageBox.Show("Successfully Uploaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


