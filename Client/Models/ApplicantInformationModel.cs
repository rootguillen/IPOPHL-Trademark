using System.ComponentModel.DataAnnotations;
using IPOPHLTrademark.Client.Shared.Enum;

namespace IPOPHLTrademark.Client.Models
{
    public class ApplicantInformationModel
    {
        //ApplicantInformation Table
        [Required(ErrorMessage = "This field is required.")]
        public string ApplicantLName { get; set; }
        
        [Required(ErrorMessage = "This field is required.")]
        public string ApplicantFName { get; set; }
        
        [Required(ErrorMessage = "This field is required.")]
        public string ApplicantMName { get; set; }
       
        [Required]
        public GenderSelect ApplicantGender { get; set; }
        
        [Required(ErrorMessage = "This field is required.")]
        public string ApplicantPosition { get; set; }
        
        [Required(ErrorMessage = "This field is required.")]
        public string NameCompanyCorpGovASch { get; set; }
        
        [Required(ErrorMessage = "This field is required.")]
        public string ApplicantAddress { get; set; }
        
        public string ApplicantCountry { get; set; }
        public string ApplicantState { get; set; }
        public string ApplicantCity { get; set; }
        
        [Required(ErrorMessage = "This field is required.")]
        public string ApplicantZipCode { get; set; }
        
        [Required(ErrorMessage = "This field is required.")]
        public string ApplicantMobNum { get; set; }
        
        [Required(ErrorMessage = "This field is required.")]
        public string ApplicantEmailAdd { get; set; }
        
        [Required]
        public string ApplicantNationality { get; set; }
    }
}
