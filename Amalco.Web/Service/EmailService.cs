using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Amalco.Data;
using Amalco.Data.Models;
using Amalco.Data.ViewModels.Order;
using Newtonsoft.Json;
using Amalco.Data.Enums;
namespace Amalco.Web.Service
{
    public class EmailService:IEmailService
    {

        private readonly Context _context;

        public EmailService (Context context)
        {
            _context = context;
        }
        public  async Task Send(OrderAddViewModel model)
        {
            Order order = new Order
            {
                Date = DateTime.UtcNow.AddHours(3),
                Comment = model.Comment,
                PhoneNumber =model.PhoneNumber,
                FullName = model.Name,
                ServiceId = model.ServiceId,
                OrderType = model.ServiceId.HasValue ? OrderType.Order : OrderType.VacancyGeneral,
               
            }; 
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();

            mailMessage.From = new MailAddress("*", "Amalco");
            mailMessage.To.Add(new MailAddress("*"));
            mailMessage.Priority = MailPriority.Normal;

            mailMessage.Subject = model.ServiceId.HasValue?"Новая заявка на услугу":"Поиск вакансии";
            mailMessage.Body = $@"Дата заявки : <b>{DateTime.UtcNow.AddHours(3)}</b>  <br />
            Имя : {model.Name}<br />
            Номер телефона : {model.PhoneNumber} <br />
            Эл.почта :   {model.Email}<br />
            Комментарий : {model.Comment}<br />
            {(model.ServiceId.HasValue?"Услуга :"+model.ServiceName:null)}
            {(model.ZanyatnostString!=null? "<br /> Занятость :"+model.ZanyatnostString : null)}
            {(model.WorkPlaceString != null ? "<br /> Место работы :"+model.WorkPlaceString : null)}

";
            mailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient
            {
                Host = "smtp-pulse.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential("*", "*")
            };

           
await smtpClient.SendMailAsync(mailMessage);
              
          
        }

        public async Task Send(string body,string subject, string to = "amalcoru@gmail.com", Stream file = null,string filename=null)
        {
            
           
            MailMessage mailMessage = new MailMessage();

            mailMessage.From = new MailAddress("*", "*");
            mailMessage.To.Add(new MailAddress(to));
            mailMessage.Priority = MailPriority.Normal;
            //mailMessage.Bcc.Add("cattus88@hotmail.com");
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            if(file !=null)
            {
              mailMessage.Attachments.Add(new Attachment(file, filename));
            }
           
 
            mailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient
            {
                Host = "smtp-pulse.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential("**", "**")
            };

           
                await smtpClient.SendMailAsync(mailMessage);

           
        }
    }
}
