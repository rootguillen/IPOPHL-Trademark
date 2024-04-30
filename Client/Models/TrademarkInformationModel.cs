using System.ComponentModel.DataAnnotations;
using IPOPHLTrademark.Client.Shared.Enum;
using IPOPHLTrademark.Client.Services;

    public class TrademarkInformationModel
    {
    //TrademarkInformation Table
    [Required(ErrorMessage = "Select your Type of Mark before proceeding.")]
    public MarkType MarkType { get; set; }
    public MarkType selectedMarkType { get; set; }

    [Required(ErrorMessage = "This field is required.")]
    public string Title { get; set; }
        
    [Required(ErrorMessage = "This field is required.")]
    public string ClaimColors { get; set; }
       
    [Required(ErrorMessage = "This field is required.")]
    public string TranslationTransliteration { get; set; }
        
    [Required(ErrorMessage = "Disclaimer is required.")]
    public string Disclaimer { get; set; }
    }

