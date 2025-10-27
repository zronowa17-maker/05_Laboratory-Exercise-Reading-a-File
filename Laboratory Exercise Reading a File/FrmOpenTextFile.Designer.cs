namespace Laboratory_Exercise_Reading_a_File
{
    partial class FrmOpenTextFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpenTextFile));
            this.lvStudentData = new System.Windows.Forms.ListView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lvStudentData
            // 
            this.lvStudentData.BackColor = System.Drawing.Color.LightGray;
            this.lvStudentData.HideSelection = false;
            this.lvStudentData.Location = new System.Drawing.Point(40, 36);
            this.lvStudentData.Name = "lvStudentData";
            this.lvStudentData.Size = new System.Drawing.Size(711, 225);
            this.lvStudentData.TabIndex = 0;
            this.lvStudentData.UseCompatibleStateImageBehavior = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.LightGray;
            this.btnOpen.Location = new System.Drawing.Point(321, 334);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(160, 37);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmOpenTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lvStudentData);
            this.Name = "FrmOpenTextFile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvStudentData;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

