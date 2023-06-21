using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Amalco.Data.Enums
{
    public enum ServiceType
    {
        [Display(Name ="Для детей")]
        ForChild=1,
        [Display(Name = "Помощь по дому")]
        ForHome,
        [Display(Name = "В загородный дом")]
        ForDatcha,
        [Display(Name = "Домашний персонал из Филиппин")]
        Foreign,
        [Display(Name = "Водители и Охрана")]
        DriverSecurity



    }
}
