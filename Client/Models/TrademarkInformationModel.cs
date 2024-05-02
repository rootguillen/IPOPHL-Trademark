using System.ComponentModel.DataAnnotations;
using IPOPHLTrademark.Client.Shared.Enum;
using IPOPHLTrademark.Client.Services;

    public class TrademarkInformationModel
    {
    //TrademarkInformation Table
    [Required]
    public MarkType MarkType { get; set; }
    public MarkType selectedMarkType { get; set; }

    [Required]
    public string Title { get; set; }
        
    [Required]
    public string ClaimColors { get; set; }
       
    [Required]
    public string TranslationTransliteration { get; set; }
        
    [Required]
    public string Disclaimer { get; set; }

    [Required]
    public string TrademarkIMG { get; set; }
    }

