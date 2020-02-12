using OnlineSinavCore.Abstract;
using OnlineSinavCore.Messages;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace OnlineSinavCore.Concrete
{
    public class EmailSender : IMessageSender
    { 
        public string SendMessage(string subject, string body)
        {
            try
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    Credentials = new System.Net.NetworkCredential("username", "password"),
                    EnableSsl = true,
                    Timeout = 100000,
                };

                var formEmail = new MailAddress("emrahaktas82@gmail.com", "Online Sinav");
                var toEmail = new MailAddress("emailID");


                using (var message = new MailMessage(formEmail, toEmail))
                {
                    //message.To.Add("to_address");
                    //message.Subject = "Test Mail";
                    message.Subject = subject;
                    message.IsBodyHtml = true;
                    message.BodyEncoding = UTF8Encoding.UTF8;
                    message.Body = body;
                    //string htmlBody;
                    //htmlBody = "Buraya biraz HTML kodu yaz";
                    //message.Body = "This is for testing SMTP message from GMAIL";
                    //message.Body = htmlBody;

                    #region Mail adresine Dosya eklemek için
                    Attachment attachment = new Attachment("your attachment file");
                    message.Attachments.Add(attachment);
                    #endregion
                    smtp.Send(message);
                }

                return "Email Gönderimi Başarılı";
                // MessageBox.Show("mail Send");
            }
            catch (System.Exception ex)
            {
                return "Sistemsel Hata Olustu Lütfen daha sonra tekrar deneyiniz.";
                throw new System.Exception("Hata Mesaji" + ex.Message);
                //MessageBox.Show(ex.ToString());
            }

            //var verifyUrl = "/User/" + emailFor + "/" + activationCode;
            //var link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifyUrl);

            //var fromEmail = new MailAddress("dotnetawesome@gmail.com", "Dotnet Awesome");
            //var toEmail = new MailAddress(emailID);
            //var fromEmailPassword = "******"; // Replace with actual password

            //string subject = "";
            //string body = "";
            //if (emailFor == "VerifyAccount")
            //{
            //    subject = "Your account is successfully created!";
            //    body = "<br/><br/>We are excited to tell you that your Dotnet Awesome account is" +
            //        " successfully created. Please click on the below link to verify your account" +
            //        " <br/><br/><a href='" + link + "'>" + link + "</a> ";
            //}
            //else if (emailFor == "ResetPassword")
            //{
            //    subject = "Reset Password";
            //    body = "Hi,<br/>br/>We got request for reset your account password. Please click on the below link to reset your password" +
            //        "<br/><br/><a href=" + link + ">Reset Password link</a>";
            //}


            //var smtp = new SmtpClient
            //{
            //    Host = "smtp.gmail.com",
            //    Port = 587,
            //    EnableSsl = true,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = false,
            //    Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
            //};

            //using (var message = new MailMessage(fromEmail, toEmail)
            //{
            //    Subject = subject,
            //    Body = body,
            //    IsBodyHtml = true
            //})
            //    smtp.Send(message);

            //return "Email Gönderimi Başarılı";
        }
    }
}
