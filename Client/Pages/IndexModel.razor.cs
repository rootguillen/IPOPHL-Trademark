﻿using Microsoft.AspNetCore.Components;
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
    }
}
