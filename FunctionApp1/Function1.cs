using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace FunctionApp1
{
    [StorageAccount("AzureWebJobsStorage")]
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([QueueTrigger("queuenamehere")] string myQueueItem, ILogger log)
        {
            var emailSource = JsonConvert.DeserializeObject<EmailContent>(myQueueItem);
            var response = SendEmail(emailSource);

            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }

        private static async Task<SendGridMessage> SendEmail(EmailContent emailSource)
        {
            var apiKey =
                "SG.keyHere"; //System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage
            {
                From = new EmailAddress("sii@example.com", "Sii Team"),
                Subject = emailSource.Subject,
                PlainTextContent = emailSource.Body,
                HtmlContent = $@"<strong>{emailSource.Body}</strong>"
            };
            msg.AddTo(new EmailAddress(emailSource.EmailTo, "Test Recipient"));
            var response = await client.SendEmailAsync(msg);
            return msg;
        }
    }
}