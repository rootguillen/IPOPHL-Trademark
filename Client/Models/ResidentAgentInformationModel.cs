using System.ComponentModel.DataAnnotations;
using IPOPHLTrademark.Client.Shared.Enum;

namespace IPOPHLTrademark.Client.Models
{
    public class ResidentAgentInformationModel
    {
        //ResidentAgentTable
        [Required ]
        public string RALName { get; set; }
        [Required ]
        public string RAFName { get; set; }
        [Required ]
        public string RAMName { get; set; }
        [Required]
        public GenderSelect RAGender { get; set; }
        [Required ]
        public string RAPosition { get; set; }
        [Required ]
        public string RAAddress { get; set; }
        public string RACountry { get; set; }
        public string RAState { get; set; }
        public string RACity { get; set; }
        [Required ]
        public string RAZipCode { get; set; }
        [Required ]
        public string RAMobNum { get; set; }
        [Required ]
        public string RAEmailAdd { get; set; }
        [Required]
        public string RANationality { get; set; }
    }
}