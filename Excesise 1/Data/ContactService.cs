using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ebs2.Data
{
  public class ContactService
  {
    public Task<bool> SendMessage(string name, string email, string msgBdy)
    {                         
      try         
      {
        MailMessage message = new MailMessage(email,
        "yoursupportemail", "question by " + name, msgBdy);

        message.IsBodyHtml = true;
        SmtpClient client = new SmtpClient("emailclient", 465);
        client.EnableSsl = true;
        client.Timeout = 30;     

        client.Credentials = new System.Net.NetworkCredential("youremail","youremailpass");
        client.Send(message);
        return Task.FromResult(true);                                                                                                                                                                                                               
      }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
      catch  (Exception ex)                                                                                                                
      {
        return Task.FromResult(false);
      }                               
    }                                                     
  }

}
