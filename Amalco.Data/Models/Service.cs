using System;
using System.Collections.Generic;
using System.Text;
using Amalco.Data.Enums;
namespace Amalco.Data.Models
{
    public class Service:Seo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MainImage { get; set; }
        public int? Price { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifedDate { get; set; }
        public string HeaderText { get; set; }
        public string Responsibility { get; set; }
        public string SubHeaderText { get; set; }
        public ServiceType? ServiceType { get; set; }
        public ServicePayType? ServicePayType { get; set; }

        public string ResponsibilityTitle { get; set; }
        public string PriceTitle { get; set; }
        public string OrderBannerImage { get; set; }
        public bool Deleted { get; set; }
    }
}
