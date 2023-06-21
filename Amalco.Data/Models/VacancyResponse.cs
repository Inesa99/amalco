using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace Amalco.Data.Models
{
    public class VacancyResponse
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public bool Experience { get; set; }
        public string CVFile { get; set; }
        public DateTime CreatedDate { get; set; }
        public int VacancyId { get; set; }
        [ForeignKey("VacancyId")]
        public virtual Vacancy Vacancy { get; set; }
    }
}
