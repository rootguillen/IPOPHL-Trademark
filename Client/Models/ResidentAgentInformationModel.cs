using System.ComponentModel.DataAnnotations;
using IPOPHLTrademark.Client.Shared.Enum;

namespace IPOPHLTrademark.Client.Models
{
    public class ResidentAgentInformationModel
    {
        //ResidentAgentTable
        [Required(ErrorMessage = "This field is required.")]
        public string RALName { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string RAFName { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string RAMName { get; set; }
        [Required]
        public GenderSelect? RAGender { get; set; } = null;
        [Required(ErrorMessage = "This field is required.")]
        public string RAPosition { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string RAAddress { get; set; }
        public string RACountry { get; set; }
        public string RAState { get; set; }
        public string RACity { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string RAZipCode { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string RAMobNum { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string RAEmailAdd { get; set; }
        [Required]
        public string RANationality { get; set; }
    }
}