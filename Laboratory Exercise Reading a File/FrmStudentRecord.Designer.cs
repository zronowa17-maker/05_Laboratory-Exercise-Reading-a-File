namespace Laboratory_Exercise_Reading_a_File
{
    partial class FrmStudentRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentRecord));
            this.lvStudentData = new System.Windows.Forms.ListView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvStudentData
            // 
            this.lvStudentData.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lvStudentData.HideSelection = false;
            this.lvStudentData.Location = new System.Drawing.Point(12, 33);
            this.lvStudentData.Name = "lvStudentData";
            this.lvStudentData.Size = new System.Drawing.Size(487, 376);
            this.lvStudentData.TabIndex = 0;
            this.lvStudentData.UseCompatibleStateImageBehavior = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRegister.Location = new System.Drawing.Point(539, 33);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(249, 94);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFind.Location = new System.Drawing.Point(539, 168);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(249, 94);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "FIND";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpload.Location = new System.Drawing.Point(539, 315);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(249, 94);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "UPLOAD";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lvStudentData);
            this.Name = "FrmStudentRecord";
            this.Text = "FrmStudentRecord";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvStudentData;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpload;
    }
}