using Amalco.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Amalco.Data.Helpers;
namespace Amalco.Data.ViewModels.Service
{
    public class ServiceListVM
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string MainImage { get; set; }
        public int? Price { get; set; }
        public ServicePayType? ServicePayType { get; set; }
        public string DisplayPayType => ServicePayType.HasValue ? ServicePayType.Value.DisplayName() : null;
    }
}
