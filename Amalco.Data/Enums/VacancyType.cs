using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Amalco.Data.Enums
{
    public enum VacancyType
    {
        [Display(Name ="Няня")]
        Nyanya=1,
        [Display(Name = "Семейная пара")]
        Para,
        [Display(Name = "Домработница")]
        Domrabotnica,
        [Display(Name = "Повар")]
        Povar,
        [Display(Name = "Персональный водитель")]
        Voditel,
        [Display(Name = "Помощник по хозяйству")]
        Pomoshnik
    }
}
