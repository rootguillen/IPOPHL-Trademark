using IPOPHLTrademark.Client.Models;
using Microsoft.AspNetCore.Components;

namespace IPOPHLTrademark.Client.Services
{
    public class ApplicantTypeManager
    {
        public TrademarkModel trademarkModel;
        public ApplicantTypeManager(TrademarkModel _trademarkModel)
        {
            trademarkModel = _trademarkModel;
        }

        public string stringChecked = "Individual";
        bool isIndividual = false;

        public void ToggleApplicantType(bool isIndividual)
        {
            trademarkModel.applicantInformation.ApplicantPosition = isIndividual ? "Not Applicable" : string.Empty;
            trademarkModel.applicantInformation.NameCompanyCorpGovASch = isIndividual ? "Not Applicable" : string.Empty;
        }
    }
}
