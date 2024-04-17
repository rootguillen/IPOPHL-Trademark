using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IPOPHLTrademark.Client.Services
{
    public class SfButtonInfo
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Label { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string CssClass { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }

    public class SfButtonService
    {
        public List<SfButtonInfo> Sfbuttons = new List<SfButtonInfo>
    {
        new SfButtonInfo {Label = "Trademark | IPOPHL Page", CssClass = "e-flat"},
        new SfButtonInfo {Label = "Declaration of Actual Use", CssClass = "e-flat"},
        new SfButtonInfo {Label = "Request for Renewal", CssClass = "e-flat"},
        // Add more buttons here...
    };

        public async Task RedirectToExternalUrl(IJSRuntime JSRuntime, string url)
        {
            await JSRuntime.InvokeVoidAsync("window.open", url, "_blank");
        }

        public async Task ButtonClicked(IJSRuntime JSRuntime, string buttonLabel)
        {
            string externalUrl = GetExternalUrlForButton(buttonLabel);
            if (!string.IsNullOrEmpty(externalUrl))
            {
                await RedirectToExternalUrl(JSRuntime, externalUrl);
            }
        }

        public string GetExternalUrlForButton(string buttonLabel)
        {
            switch (buttonLabel)
            {
                case "Trademark | IPOPHL Page":
                    return "https://www.ipophil.gov.ph/trademark/";
                case "Declaration of Actual Use":
                    return ""; // Add URL for Declaration of Actual Use
                case "Request for Renewal":
                    return ""; // Add URL for Request for Renewal
                default:
#pragma warning disable CS8603 // Possible null reference return.
                    return null;
#pragma warning restore CS8603 // Possible null reference return.
            }
        }
    }
}
