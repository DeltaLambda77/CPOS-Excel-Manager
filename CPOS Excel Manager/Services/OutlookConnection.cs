using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPOS_Excel_Manager.Models;
using CPOS_Excel_Manager.Views;
using MailKit.Net.Pop3;
using MimeKit;

namespace CPOS_Excel_Manager.Services
{
    public static class OutlookConnection
    {
        public static string ConnectPop3Client()
        {
            try
            {
                using (var client = new Pop3Client())
                {
                    client.Connect("outlook.office365.com", 995, MailKit.Security.SecureSocketOptions.Auto);
                    client.Authenticate(LoginCredentials.loginEmail, LoginCredentials.loginPassword);

                    int cenPOSAttachments = 0;
                    int i = client.Count;
                    while (cenPOSAttachments != 2)
                    {
                        var message = client.GetMessage(i - 1);
                        var mailbox = message.From.Mailboxes.ToString();

                        string messageDate = message.Date.ToString("MM/dd/yyyy");


                        Console.WriteLine(messageDate);

                        string fromLine = message.From.ToString();
                        int emailStart = fromLine.IndexOf("<") + 1;
                        int emailEnd = fromLine.IndexOf(">");
                        string email = fromLine.Substring(emailStart, emailEnd - emailStart);
                        Console.WriteLine(email);

                        //this needs to be changed in production to email -> cenpos messageDate -> yesterday
                        if (email == "*******************" && messageDate == "12/30/2022")
                        {
                            saveCenPOSAttachment(message);
                            cenPOSAttachments++;
                        }
                        i--;
                    }

                    client.Disconnect(true);
                    return "connected succesfully";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private static void saveCenPOSAttachment(MimeMessage message)
        {
            foreach (var attachment in message.Attachments)
            {
                if (attachment is not MessagePart)
                {
                    string emailSubject = message.Subject;
                    //needs to take in year of EmailDate
                    string[] attachmentSubject = emailSubject.Split(" 2022");

                    var part = (MimePart)attachment;
                    var fileName = $"{attachmentSubject[0]}.xlsx";

                    using (var stream = File.Create(fileName))
                        part.Content.DecodeTo(stream);
                    Console.WriteLine(fileName);
                }
            }
        }
    }
}
