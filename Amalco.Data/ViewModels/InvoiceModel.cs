using System;
using System.Collections.Generic;
using System.Text;

namespace Amalco.Data.ViewModels
{
   public class InvoiceModel
    {
        public int Id { get; set; }
        public string UniqueId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ServiceName { get; set; }
        public double Amount { get; set; }
        public string Note { get; set; }
        public bool IsPaid { get; set; }
        public DateTime? PaymentDate { get; set; }
    }
}
