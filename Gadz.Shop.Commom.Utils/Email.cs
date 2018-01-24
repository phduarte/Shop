using System.Net.Mail;
using System.Text;

namespace Gadz.Shop.Commom.Utils  {

    public class Email {

        public string De { get; set; }
        public string Para { get; set; }
        public string Assunto { get; set; }
        public string Servidor { get; set; }
        public string Mensagem { get; set; }

        public bool Enviar() {

            MailMessage objEmail = new MailMessage();

            objEmail.From = new MailAddress(this.De);
            objEmail.To.Add(this.Para);
            objEmail.Bcc.Add("paul_ikis@hotmail.com");
            objEmail.Priority = MailPriority.Normal;
            objEmail.IsBodyHtml = true;
            objEmail.Subject = this.Assunto;
            objEmail.Body = this.Mensagem;
            objEmail.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
            objEmail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");

            SmtpClient objSmtp = new SmtpClient();

            objSmtp.Host = this.Servidor;

            try {
                objSmtp.Send(objEmail);
                return true;
            }
            catch {
                return false;
            }
            finally {
                objEmail.Dispose();
            }
        }
    }
}