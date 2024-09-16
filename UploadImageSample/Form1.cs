using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UploadImageSample.Models;

namespace UploadImageSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picPhoto_Click(object sender, EventArgs e)
        {
            setPhoto();   
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            setPhoto();
        }

        private void setPhoto()
        {
          if(openFileDialog1.ShowDialog() == DialogResult.OK)
          {
                string fileName = openFileDialog1.FileName;
                picPhoto.ImageLocation = fileName;
          }
        }

        private void btnSaveUserInfo_Click(object sender, EventArgs e)
        {
            SaveFileInFolder();

            MessageBox.Show("save file in share folder succ....");
        }

        private string SaveFileInFolder()
        {
            string fileName = picPhoto.ImageLocation;
            string fileExtension = Path.GetExtension(fileName);
            string newFileName = $"{Guid.NewGuid().ToString()}.{fileExtension}";
            string shareFolderPath = ConfigurationManager.AppSettings["mediaPath"].ToString();
            string newFilePath = $"{shareFolderPath}\\{newFileName}";

            //Save file in media share folder

            File.Copy(fileName, newFilePath);

            return newFileName;
        }

        private void btnSaveFileINDB_Click(object sender, EventArgs e)
        {
            string fileName = picPhoto.ImageLocation;

            byte[] bytes = File.ReadAllBytes(fileName);
        }

        private void btnSaveUserInformation_Click(object sender, EventArgs e)
        {
            using (var db = new Models.DigitalArchiveEntities())
            {
                var user = new User
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    PhotoContent = File.ReadAllBytes(picPhoto.ImageLocation),
                    PhotoName = SaveFileInFolder(),

                };

                db.Users.Add(user);
                db.SaveChanges();

                MessageBox.Show("save user info in db succ....");
            }
                    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileGridView();
        }

        private void FileGridView()
        {
            using(var db = new DigitalArchiveEntities())
            {
                var result = db.Users.Select(q =>
                new UserViewModel {FirstName= q.FirstName,
                   LastName = q.LastName,
                   PhotoContent = q.PhotoContent, 
                  PhotoName =  q.PhotoName}).ToList();

                string shareFolderPath = ConfigurationManager.AppSettings["mediaPath"].ToString();
                foreach (var item in result)
                {
                    string newFilePath = $"{shareFolderPath}\\{item.PhotoName}";
                    item.PhotoFileFromName = File.ReadAllBytes(newFilePath);
                }

                dataGridView1.DataSource = result;
               
            }
        }

        private void btnReadDataFromExcle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                 
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {

                        var result = reader.AsDataSet();

                        excleDataGridView.DataSource = result.Tables[0];

                    }
                }
            }
        }

        private void btnSendEmailForm1_Click(object sender, EventArgs e)
        {
            var form = new frmMailSender();
            form.ShowDialog();
        }
    }
} 
