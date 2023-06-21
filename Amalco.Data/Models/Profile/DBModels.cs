using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Amalco.Data.Models.Profile
{
    public class Info
    {
        public int ID { get; set; }
        [MaxLength(250)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(250)]

        public string LastName { get; set; }
        [MaxLength(250)]
        public string MiddleName { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        [MaxLength(100)]
        public string MobilePhone { get; set; }
        [MaxLength(100)]
        public string HomePhone { get; set; }
        //public Metro metro { get; set; }
        //public Nationality nationality { get; set; }
        //public Religion religion { get; set; }
        //public Education education { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? WriteDate { get; set; }
        public DateTime AddDate { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public bool Passport { get; set; }
        [MaxLength(500)]
        public string FacTicAddress { get; set; }
        [MaxLength(500)]
        public string RegisterAddress { get; set; }
        [MaxLength(500)]
        public string FamilyStatus { get; set; }
        public bool MedicalBook { get; set; }
        [MaxLength(500)]
        public string Diplom { get; set; }
        [MaxLength(1000)]
        public string MoreEducation { get; set; }
        [MaxLength(10)]
        public string DriveCategory { get; set; }
        public bool DriveExperience { get; set; }
        public bool InterPassport { get; set; }
        public bool Abroad { get; set; }
        public bool Datcha { get; set; }
        [MaxLength(20)]
        public string languages { get; set; }
        public string Recommendations { get; set; }
        [MaxLength(20)]
        public string Status { get; set; }
        public int? Pay { get; set; }
        [MaxLength(10)]
        public string Valute { get; set; }
        public string WorkLeave { get; set; }
        public string WorkExperience { get; set; }
        public string About { get; set; }
        [MaxLength(1000)]
        public string MoreWork { get; set; }
        [MaxLength(200)]
        public string Smoke { get; set; }
        [MaxLength(200)]
        public string Alcohol { get; set; }
        [MaxLength(200)]
        public string Criminal { get; set; }
        [MaxLength(40)]
        public string amusement { get; set; }
        public string FamilyExperience { get; set; }
        [MaxLength(50)]
        public string SourceInfo { get; set; }
        [MaxLength(50)]
        public string ManagerLogin { get; set; }
        public string Video { get; set; }
        public bool ShowInWebSite { get; set; }
        public Info()
        {
            Status = "1";
        }
    }

    public class Nyanya : Info
    {
        [MaxLength(20)]
        public string type { get; set; }
        [MaxLength(400)]
        public string Methotds { get; set; }
        public bool isBaby { get; set; }
        public bool Music { get; set; }
        [MaxLength(10)]
        public string age_category { get; set; }
        public bool isClean { get; set; }
        public bool isCook { get; set; }

        public DateTime? Visa { get; set; }
    }

    public class Domrabotnica : Info
    {
        [MaxLength(20)]
        public string type { get; set; }
        [MaxLength(150)]
        public string poverxnost { get; set; }
        [MaxLength(1000)]
        public string specbit { get; set; }
        public bool vipgarderob { get; set; }
        public bool yarlik { get; set; }
        [MaxLength(100)]
        public string brands { get; set; }
        [MaxLength(1000)]
        public string AnimalCare { get; set; }
        public bool babywatch { get; set; }
        public bool isCook { get; set; }
        public DateTime? Visa { get; set; }
    }

    public class Sidelka : Info
    {
        [MaxLength(50)]
        public string PatientType { get; set; }
        [MaxLength(10)]
        public string PatientSex { get; set; }
        [MaxLength(100)]
        public string Medecine { get; set; }
        public bool isClean { get; set; }
    }
    public class Voditel : Info
    {
        public bool isAuto { get; set; }
        [MaxLength(1000)]
        public string responsibility { get; set; }
        public bool isGun { get; set; }
        public bool annormalDay { get; set; }
        public bool personalGuard { get; set; }
        [MaxLength(50)]
        public string CarList { get; set; }
    }

    public class Povar : Info
    {
        [MaxLength(50)]
        public string WorldCook { get; set; }
        public bool Diet { get; set; }
        public bool Razdelnoe { get; set; }
        public bool Zakupka { get; set; }
        public bool isClean { get; set; }
    }

    public class Semeynaya_Para : Info
    {
        [MaxLength(250)]
        [Required]
        public string FirstName_w { get; set; }
        [MaxLength(250)]
        public string LastName_w { get; set; }
        [MaxLength(250)]
        public string MiddleName_w { get; set; }
        [MaxLength(50)]
        public string Image_w { get; set; }
        [MaxLength(100)]
        public string MobilePhone_w { get; set; }
        //public Nationality nationality_w { get; set; }
        //public Religion religion_w { get; set; }
        //public Education education_w { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate_w { get; set; }
        public double? Weight_w { get; set; }
        public double? Height_w { get; set; }
        public bool Passport_w { get; set; }
        public bool MedicalBook_w { get; set; }
        [MaxLength(500)]
        public string Diplom_w { get; set; }
        [MaxLength(1000)]
        public string MoreEducation_w { get; set; }
        [MaxLength(10)]
        public string DriveCategory_w { get; set; }
        public bool DriveExperience_w { get; set; }
        public bool InterPassport_w { get; set; }
        public bool Abroad_w { get; set; }
        public bool Datcha_w { get; set; }
        [MaxLength(20)]
        public string languages_w { get; set; }
        public string About_w { get; set; }
        [MaxLength(1000)]
        public string MoreWork_w { get; set; }
        [MaxLength(200)]
        public string Smoke_w { get; set; }
        [MaxLength(200)]
        public string Alcohol_w { get; set; }
        [MaxLength(200)]
        public string Criminal_w { get; set; }

        [MaxLength(2000)]
        public string obyaz { get; set; }
        [MaxLength(2000)]
        public string obyaz_w { get; set; }
        [MaxLength(150)]
        public string poverxnost { get; set; }
        [MaxLength(1000)]
        public string specbit { get; set; }
        public bool vipgarderob { get; set; }
        public string AnimalCare { get; set; }
        public bool babywatch { get; set; }
        public bool isCook { get; set; }
        [MaxLength(1000)]
        public string SadInstrument { get; set; }
        [MaxLength(1000)]
        public string p_habits { get; set; }
    }

    public class ForeignStaff : Info
    {
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? RFWorkStart { get; set; }
        public bool othercity { get; set; }
        [MaxLength(20)]
        public string type { get; set; }
        [MaxLength(400)]
        public string Methotds { get; set; }
        public bool isBaby { get; set; }

        [MaxLength(10)]
        public string age_category { get; set; }
        public bool isClean { get; set; }
        public bool isCook { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Visa { get; set; }
    }

    public class Assistant : Info
    {
        public string HaveCare { get; set; }
        public bool workWithselfauto { get; set; }
        public string GardenInstrumet { get; set; }
        public string PlaceThings { get; set; }

    }
}
