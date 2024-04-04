using System.ComponentModel.DataAnnotations;

namespace IPOPHLTrademark.Client.Pages
{
    public partial class RegistrationForm
    {
        private bool infoTrademark = false;
        private bool applicantInfo = false;
        private bool residentAgent = false;
        private bool goodsServices = false;

        private void InfoTrademark()
        {
            infoTrademark = true;
            applicantInfo = false;
            residentAgent = false;
            goodsServices = false;
        }
        private void ApplicantInfo()
        {
            infoTrademark = false;
            applicantInfo = true;
            residentAgent = false;
            goodsServices = false;
        }
        private void ResidentAgent()
        {
            infoTrademark = false;
            applicantInfo = false;
            residentAgent = true;
            goodsServices = false;
        }
        private void GoodsServices()
        {
            infoTrademark = false;
            applicantInfo = false;
            residentAgent = false;
            goodsServices = true;
        }

        enum MarkType
        {
            None,
            Word,
            Figurative,
            FigurativeWithWord,
            ThreeD,
            Collective,
        }

        enum GenderSelect
        {
            Male,
            Female,
        }

        class TrademarkModel
        {
            [Required(ErrorMessage = "Please select a type of mark.")]
            public MarkType SelectedMarkType { get; set; }

            [Required(ErrorMessage = "This field is required.")]
            public string Title { get; set; }
            [Required(ErrorMessage = "This field is required.")]
            public string ClaimColors { get; set; }
            [Required(ErrorMessage = "This field is required.")]
            public string TranslationTransliteration { get; set; }
            [Required(ErrorMessage = "Disclaimer is required.")]
            public string Disclaimer { get; set; }

            [Required(ErrorMessage = "This field is required.")]
            public string ApplicantLName { get; set; }
            [Required(ErrorMessage = "This field is required.")]
            public string ApplicantFName { get; set; }
            [Required(ErrorMessage = "This field is required.")]
            public string ApplicantMName { get; set; }
            [Required]
            public GenderSelect? ApplicantGender { get; set; } = null;
            [Required(ErrorMessage = "This field is required.")]
            public string ApplicantPosition { get; set; }
            [Required(ErrorMessage = "This field is required.")]
            public string NameCompanyCorpGovASch { get; set; }
            [Required(ErrorMessage = "This field is required.")]
            public string ApplicantAddress { get; set; }
            //public string ApplicantCountry { get; set; }
            //public string ApplicantState { get; set; }
            //public string ApplicantCity { get; set; }
            [Required(ErrorMessage = "This field is required.")]
            public string ApplicantZipCode { get; set; }
            [Required(ErrorMessage = "This field is required.")]
            public string ApplicantMobNum { get; set; }
            [Required(ErrorMessage = "This field is required.")]
            public string ApplicantEmailAdd { get; set; }
            [Required]
            public string ApplicantNationality { get; set; }


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
            //public string RACountry { get; set; }
            //public string RAState { get; set; }
            //public string RACity { get; set; }
            [Required(ErrorMessage = "This field is required.")]
            public string RAZipCode { get; set; }
            [Required(ErrorMessage = "This field is required.")]
            public string RAMobNum { get; set; }
            [Required(ErrorMessage = "This field is required.")]
            public string RAEmailAdd { get; set; }
            [Required]
            public string RANationality { get; set; }

            [Required]
            public string NClass { get; set; }
            [Required(ErrorMessage = "This field is required.")]
            public string GSComments { get; set; }

            [Required]
            public string ApplicantType { get; set; }
            public bool IsIndividual { get; set; }


            [Required(ErrorMessage = "This field is required.")]
            public string PriorForeignApplicationNo { get; set; }
            [Required]
            public DateTime? DateValue { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 10);
            [Required]
            public string CCPCountry { get; set; }

        }
        TrademarkModel trademarkModel = new TrademarkModel();

        void SelectMarkType(MarkType markType)
        {
            trademarkModel.SelectedMarkType = markType;
        }

        bool claimConventionPriority = true;
        void ToggleConventionPriority(bool value)
        {
            claimConventionPriority = value;
        }

        bool isIndividualSelected = false;
        void ToggleApplicantType(bool isIndividual)
        {
            isIndividualSelected = isIndividual;
        }

        private List<TrademarkModel> trademarkModels = new List<TrademarkModel>();
        private void AddNewGroup()
        {
            trademarkModels.Add(new TrademarkModel());
        }

        bool submitted = false;
        private void Submit() => submitted = true;

        void HandleValidSubmit()
        {
            // Handle form submission
        }
    }
}
