using System.ComponentModel.DataAnnotations;

namespace IPOPHLTrademark.Client.Models
{
    public class GoodsServicesInformationModel
    {
        //GoodsServices Table
        [Required]
        public string NClass { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string GSComments { get; set; }
    }
}
