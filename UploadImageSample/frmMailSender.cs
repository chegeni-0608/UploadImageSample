using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UploadImageSample
{
    public partial class frmMailSender : Form
    {
        public frmMailSender()
        {
            InitializeComponent();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string senderEmail = "mmoa80610@gmail.com";
            string senderMailPassword = "6365Mraa";

            //create mail message
            var message = new MailMessage();
            message.Subject = txtSubject.Text;
            message.Body = txtBody.Text;
            message.To.Add(txtTo.Text);
            message.From = new MailAddress(senderEmail);

            //create smtp client
            var smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new System.Net.NetworkCredential(senderEmail, senderMailPassword);
            smtp.Send(message);

            MessageBox.Show("send email succ.....");

        }
    }
}
