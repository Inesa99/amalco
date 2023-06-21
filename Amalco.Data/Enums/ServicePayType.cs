using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Amalco.Data.Enums
{
    public enum ServicePayType : byte
    {
        [Display(Name = "час")]
        Hour = 1,
        [Display(Name = "выход")]
        Once,
        [Display(Name = "мес.")]
        Month,
        [Display(Name = "за сутки")]
        Day
        
    }
}
