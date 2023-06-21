using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net.Mail;

namespace Amalco.Data.ViewModels.Order
{
    public class OrderAddViewModel
    {
        public int? ServiceId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Comment { get; set; }
        public string ServiceName { get; set; }
        public List<string> Zanyatnost { get; set; }
        public List<string> WorkPlace { get; set; }
        public string CrmCookie { get; set; }
        public Attachment Attachment { get; set; }
        public string pipeline { get; set; }
        public string ZanyatnostString
        {
            get
            {
                if(Zanyatnost!=null&& Zanyatnost.Any())
                {
                    return String.Join(",", Zanyatnost);
                }
                return null;
            }
        }
        public string WorkPlaceString
        {
            get
            {
                if (WorkPlace != null && WorkPlace.Any())
                {
                    return String.Join(",", WorkPlace);
                }
                return null;
            }
        }
    }
}
