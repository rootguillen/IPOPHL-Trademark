using System.ComponentModel.DataAnnotations;
using IPOPHLTrademark.Client.Shared.Enum;

namespace IPOPHLTrademark.Client.Models
{
    public class ApplicantInformationModel
    {
        //ApplicantInformation Table
        [Required]
        public string ApplicantLName { get; set; }
        
        [Required]
        public string ApplicantFName { get; set; }
        
        public string ApplicantMName { get; set; }
       
        [Required]
        public GenderSelect ApplicantGender { get; set; }
        
        [Required]
        public string ApplicantPosition { get; set; }
        
        [Required]
        public string NameCompanyCorpGovASch { get; set; }
        
        [Required]
        public string ApplicantAddress { get; set; }

        [Required]
        public string ApplicantCountry { get; set; }
        [Required]
        public string ApplicantState { get; set; }
        [Required]
        public string ApplicantCity { get; set; }
        
        [Required]
        public string ApplicantZipCode { get; set; }
        
        [Required]
        public string ApplicantMobNum { get; set; }
        
        [Required]
        public string ApplicantEmailAdd { get; set; }
        
        [Required]
        public string ApplicantNationality { get; set; }
    }
}
