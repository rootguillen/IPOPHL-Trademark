using Microsoft.AspNetCore.Components;
using IPOPHLTrademark.Client.Models;
using System;


namespace IPOPHLTrademark.Client.Pages
{
    public partial class IndexModel : ComponentBase
    {
        public TrademarkModel trademarkModel {  get; set; } = new TrademarkModel();

        public NationalityDataModel nationalityModel { get; set; } = new NationalityDataModel();

        public void HandleValidSubmit()
        {

            // Reset the form after saving
            trademarkModel = new TrademarkModel();
        }

        public bool genderSelected = true;


        //for submit preview button with modal
        public bool IsOuterDialogVisible { get; set; } = false;
        public bool IsInnerDialogVisible { get; set; } = false;

        public void OpenOuterDialog()
        {
            IsOuterDialogVisible = true;
        }

        public void OpenInnerDialog()
        {
            IsInnerDialogVisible = true;
        }

        public void CloseInnerDialog()
        {
            IsOuterDialogVisible = false;
            IsInnerDialogVisible = false;
        }
    }
}
