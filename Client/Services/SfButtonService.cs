using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IPOPHLTrademark.Client.Services
{
    public class SfButtonInfo
    {
        public string Label { get; set; }
        public string CssClass { get; set; }
    }

    public class SfButtonService
    {
        public List<SfButtonInfo> Sfbuttons = new List<SfButtonInfo>
    {
        new SfButtonInfo {Label = "Trademark | IPOPHL Page", CssClass = "e-flat"},
        new SfButtonInfo {Label = "Declaration of Actual Use", CssClass = "e-flat"  },
        new SfButtonInfo {Label = "Request for Renewal", CssClass = "e-flat"  },
        new SfButtonInfo {Label = "Request for Revival in Publication", CssClass = "e-flat"  },
        new SfButtonInfo {Label = "Request for Priority Exam", CssClass = "e-flat" },
        new SfButtonInfo {Label = "Request for Suspension of Action", CssClass = "e-flat"  },
        new SfButtonInfo {Label = "Extension of Time to File Response", CssClass = "e-flat"  },
        new SfButtonInfo {Label = "Assignment of Application for Registration of TM", CssClass = "e-flat"  },
        new SfButtonInfo {Label = "Assignment of Registered Trademark", CssClass = "e-flat"  }
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
