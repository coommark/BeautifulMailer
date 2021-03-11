using System.Collections.Generic;

namespace BeautifulMailer.Utils
{
    public interface IMailSender
    {
        void SendPlaintextGmail(string recipientEmail, string recipientName);
        void SendHtmlGmail(string recipientEmail, string recipientName);
        void SendHtmlWithAttachmentGmail(string recipientEmail, string recipientName);

        void SendPlaintextSendgrid(string recipientEmail, string recipientName);
        void SendHtmlSendgrid(string recipientEmail, string recipientName);
        void SendHtmlWithAttachmentSendgrid(string recipientEmail, string recipientName);
        void SendSendgridBulk(IEnumerable<string> recipientEmails);
    }
}
