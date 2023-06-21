using Amalco.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Amalco.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int? VacancyId { get; set; }
        public int? ServiceId { get; set; }
        public OrderType OrderType { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Comment { get; set; }
      
        [ForeignKey("ServiceId")]
        public virtual Service Service { get; set; }

    }
}
