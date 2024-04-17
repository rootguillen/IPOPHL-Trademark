using System.ComponentModel.DataAnnotations;

namespace IPOPHLTrademark.Client.Models
{
    public class TrademarkModel
    {
        public TrademarkInformationModel trademarkInformation { get; set; } = new TrademarkInformationModel();
        public ApplicantInformationModel applicantInformation { get; set; } = new ApplicantInformationModel();
        public ApplicantTypeModel applicantType { get; set; } = new ApplicantTypeModel();
        public ResidentAgentInformationModel residentAgentInformation { get; set; } = new ResidentAgentInformationModel();
        public GoodsServicesInformationModel goodsServicesInformation { get; set; } = new GoodsServicesInformationModel();
        public ClaimConventionPriorityModel claimConventionPriority { get; set; } = new ClaimConventionPriorityModel();


    }
}
