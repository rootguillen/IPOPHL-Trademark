using System.ComponentModel.DataAnnotations;
using IPOPHLTrademark.Client.Shared.Enum;

namespace IPOPHLTrademark.Client.Models
{
    public class ClaimConventionPriorityModel
    {
        //ClaimConventionPriority Table
        [Required]
        public string PriorForeignApplicationNo { get; set; }
        [Required]
        public DateTime? DateValue { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 10);
        [Required]
        public string CCPCountry { get; set; }
    }
}
