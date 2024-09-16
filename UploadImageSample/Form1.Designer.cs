namespace UploadImageSample
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveUserInformation = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveFileINDB = new System.Windows.Forms.Button();
            this.btnSaveUserInfo = new System.Windows.Forms.Button();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotoContent = new System.Windows.Forms.DataGridViewImageColumn();
            this.PhotoFramName = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnReadDataFromExcle = new System.Windows.Forms.Button();
            this.excleDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSendEmailForm1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveUserInformation);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSaveFileINDB);
            this.groupBox1.Controls.Add(this.btnSaveUserInfo);
            this.groupBox1.Controls.Add(this.btnChoosePhoto);
            this.groupBox1.Controls.Add(this.picPhoto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upload Photo";
            // 
            // btnSaveUserInformation
            // 
            this.btnSaveUserInformation.Location = new System.Drawing.Point(138, 140);
            this.btnSaveUserInformation.Name = "btnSaveUserInformation";
            this.btnSaveUserInformation.Size = new System.Drawing.Size(134, 81);
            this.btnSaveUserInformation.TabIndex = 8;
            this.btnSaveUserInformation.Text = "Save User Info in DB + with Photo";
            this.btnSaveUserInformation.UseVisualStyleBackColor = true;
            this.btnSaveUserInformation.Click += new System.EventHandler(this.btnSaveUserInformation_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(206, 64);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(95, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(206, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(95, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name :";
            // 
            // btnSaveFileINDB
            // 
            this.btnSaveFileINDB.Location = new System.Drawing.Point(19, 198);
            this.btnSaveFileINDB.Name = "btnSaveFileINDB";
            this.btnSaveFileINDB.Size = new System.Drawing.Size(113, 23);
            this.btnSaveFileINDB.TabIndex = 3;
            this.btnSaveFileINDB.Text = "Save File In DB";
            this.btnSaveFileINDB.UseVisualStyleBackColor = true;
            this.btnSaveFileINDB.Click += new System.EventHandler(this.btnSaveFileINDB_Click);
            // 
            // btnSaveUserInfo
            // 
            this.btnSaveUserInfo.Location = new System.Drawing.Point(19, 169);
            this.btnSaveUserInfo.Name = "btnSaveUserInfo";
            this.btnSaveUserInfo.Size = new System.Drawing.Size(113, 23);
            this.btnSaveUserInfo.TabIndex = 2;
            this.btnSaveUserInfo.Text = "Save File in Folder";
            this.btnSaveUserInfo.UseVisualStyleBackColor = true;
            this.btnSaveUserInfo.Click += new System.EventHandler(this.btnSaveUserInfo_Click);
            // 
            // btnChoosePhoto
            // 
            this.btnChoosePhoto.Location = new System.Drawing.Point(19, 140);
            this.btnChoosePhoto.Name = "btnChoosePhoto";
            this.btnChoosePhoto.Size = new System.Drawing.Size(113, 23);
            this.btnChoosePhoto.TabIndex = 1;
            this.btnChoosePhoto.Text = "Choose Photo";
            this.btnChoosePhoto.UseVisualStyleBackColor = true;
            this.btnChoosePhoto.Click += new System.EventHandler(this.btnChoosePhoto_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.Image = global::UploadImageSample.Properties.Resources.user1;
            this.picPhoto.Location = new System.Drawing.Point(19, 19);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(103, 115);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            this.picPhoto.Click += new System.EventHandler(this.picPhoto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.excleDataGridView);
            this.groupBox2.Controls.Add(this.btnReadDataFromExcle);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(338, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.PhotoContent,
            this.PhotoFramName});
            this.dataGridView1.Location = new System.Drawing.Point(0, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // PhotoContent
            // 
            this.PhotoContent.DataPropertyName = "PhotoContent";
            this.PhotoContent.FillWeight = 250F;
            this.PhotoContent.HeaderText = "Photo Content";
            this.PhotoContent.Name = "PhotoContent";
            // 
            // PhotoFramName
            // 
            this.PhotoFramName.DataPropertyName = "PhotoFileFromName";
            this.PhotoFramName.HeaderText = "Photo Fram Name";
            this.PhotoFramName.Name = "PhotoFramName";
            // 
            // btnReadDataFromExcle
            // 
            this.btnReadDataFromExcle.Location = new System.Drawing.Point(439, 14);
            this.btnReadDataFromExcle.Name = "btnReadDataFromExcle";
            this.btnReadDataFromExcle.Size = new System.Drawing.Size(196, 58);
            this.btnReadDataFromExcle.TabIndex = 2;
            this.btnReadDataFromExcle.Text = "Read Data From Excle File";
            this.btnReadDataFromExcle.UseVisualStyleBackColor = true;
            this.btnReadDataFromExcle.Click += new System.EventHandler(this.btnReadDataFromExcle_Click);
            // 
            // excleDataGridView
            // 
            this.excleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.excleDataGridView.Location = new System.Drawing.Point(439, 92);
            this.excleDataGridView.Name = "excleDataGridView";
            this.excleDataGridView.Size = new System.Drawing.Size(215, 176);
            this.excleDataGridView.TabIndex = 3;
            // 
            // btnSendEmailForm1
            // 
            this.btnSendEmailForm1.Location = new System.Drawing.Point(338, 292);
            this.btnSendEmailForm1.Name = "btnSendEmailForm1";
            this.btnSendEmailForm1.Size = new System.Drawing.Size(254, 33);
            this.btnSendEmailForm1.TabIndex = 9;
            this.btnSendEmailForm1.Text = "Send Email";
            this.btnSendEmailForm1.UseVisualStyleBackColor = true;
            this.btnSendEmailForm1.Click += new System.EventHandler(this.btnSendEmailForm1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.btnSendEmailForm1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChoosePhoto;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSaveUserInfo;
        private System.Windows.Forms.Button btnSaveFileINDB;
        private System.Windows.Forms.Button btnSaveUserInformation;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewImageColumn PhotoContent;
        private System.Windows.Forms.DataGridViewImageColumn PhotoFramName;
        private System.Windows.Forms.Button btnReadDataFromExcle;
        private System.Windows.Forms.DataGridView excleDataGridView;
        private System.Windows.Forms.Button btnSendEmailForm1;
    }
}

