using System;
using System.Collections.Generic;
using System.Text;

namespace Amalco.Data.ViewModels.Order
{
    public class VacancyResponseModel
    {
        public string VacancyName { get; set; }
        public string FullName { get; set; }
        public DateTime Date { get; set; }
        public string PhoneNumber { get; set; }
        public bool FamilyExperience { get; set; }
        public bool HasCv { get; set; }
    }
}
