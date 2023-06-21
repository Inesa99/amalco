using Amalco.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amalco.Data.ViewModels.Service
{
    public class VacancyVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Salary { get; set; }
        public int? SalaryDo { get; set; }
        public DateTime CreatedDate { get; set; }
        public VacancyType VacancyType { get; set; }
        public ServicePayType ServicePayType { get; set; }
    }
}
