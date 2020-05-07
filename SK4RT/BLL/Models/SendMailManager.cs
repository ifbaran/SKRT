using System;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Windows.Forms;

namespace BLL.Models
{
    public class SendMailManager
    {
        public void SendMail(string txtWhom, string txtSubject, string richTxtContent)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("sk4rtcvs@gmail.com", "SK4RT | Cinema & Theater Reservation");

            message.To.Add(txtWhom);
            message.Subject = txtSubject;
            message.Body = richTxtContent;

            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("sk4rtcvs@gmail.com", "SK4RTAPP1.@");
            object userState = message;
            bool isThereInternet = false;

            try
            {
                System.Net.Sockets.TcpClient controlClient = new TcpClient("www.google.com", 80);
                isThereInternet = true;
            }
            catch (Exception e)
            {
                isThereInternet = false;
            }

            if (isThereInternet == true)
            {
                if (txtSubject != string.Empty || richTxtContent != string.Empty)
                {
                    try
                    {
                        client.Send(message);
                        MessageBox.Show("Mail sent.");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Mail not sent.");
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all line.");
                }
            }
            else
            {
                MessageBox.Show("Please check your intenet connection.");
            }
        }
    }
}