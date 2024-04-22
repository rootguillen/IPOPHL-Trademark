using System.ComponentModel.DataAnnotations;
using IPOPHLTrademark.Client.Shared.Enum;

namespace IPOPHLTrademark.Client.Models
{
    public class ApplicantTypeModel
    {
        public ApplicantType ApplicantType { get; set; }
        public bool IsIndividualSelected {  get; set; }
    }
}
