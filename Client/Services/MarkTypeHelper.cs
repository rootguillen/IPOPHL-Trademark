namespace IPOPHLTrademark.Client.Services
{

    public static class MarkTypeHelper
    {
        public static IPOPHLTrademark.Client.Shared.Enum.MarkType? selectedMarkType = null;

        public static void SelectMarkType(IPOPHLTrademark.Client.Shared.Enum.MarkType markType)
        {
            if (selectedMarkType == markType)
            {
                selectedMarkType = null;
            }
            else
            {
                selectedMarkType = markType;
            }
        }

        public static string GetButtonClass(IPOPHLTrademark.Client.Shared.Enum.MarkType markType)
        {
            return selectedMarkType == markType ? "btn btn-dark" : "btn btn-light";
        }

        public static string GetMarkTypeImagePath(IPOPHLTrademark.Client.Shared.Enum.MarkType markType)
        {
            if (markType == IPOPHLTrademark.Client.Shared.Enum.MarkType.None)
            {
                return "";
            }

            string imageName = markType switch
            {
                IPOPHLTrademark.Client.Shared.Enum.MarkType.Word => "tm-wm.png",
                IPOPHLTrademark.Client.Shared.Enum.MarkType.Figurative => "tm-fm.png",
                IPOPHLTrademark.Client.Shared.Enum.MarkType.FigurativeWithWord => "tm-fwm.png",
                IPOPHLTrademark.Client.Shared.Enum.MarkType.ThreeD => "tm-dm.png",
                IPOPHLTrademark.Client.Shared.Enum.MarkType.Collective => "tm-cm.png",
                _ => ""
            };

            return $"regisForm-img/{imageName}";
        }

        public static string GetMarkTypeAltText(IPOPHLTrademark.Client.Shared.Enum.MarkType markType)
        {
            return markType == IPOPHLTrademark.Client.Shared.Enum.MarkType.None ? "" : markType.ToString();
        }

        public static string GetMarkTypeTitle(IPOPHLTrademark.Client.Shared.Enum.MarkType markType)
        {
            return markType switch
            {
                IPOPHLTrademark.Client.Shared.Enum.MarkType.Word => "Word Mark",
                IPOPHLTrademark.Client.Shared.Enum.MarkType.Figurative => "Figurative Mark",
                IPOPHLTrademark.Client.Shared.Enum.MarkType.FigurativeWithWord => "Figurative with Word Mark",
                IPOPHLTrademark.Client.Shared.Enum.MarkType.ThreeD => "3D Mark",
                IPOPHLTrademark.Client.Shared.Enum.MarkType.Collective => "Collective Mark",
                _ => ""
            };
        }

        public static string GetMarkTypeDescription(IPOPHLTrademark.Client.Shared.Enum.MarkType markType)
        {
            return markType switch
            {
                IPOPHLTrademark.Client.Shared.Enum.MarkType.Word => "A word mark consists solely of words, letters, or numbers without any design elements.",
                IPOPHLTrademark.Client.Shared.Enum.MarkType.Figurative => "A figurative mark includes designs, graphics, symbols, or images.",
                IPOPHLTrademark.Client.Shared.Enum.MarkType.FigurativeWithWord => "A combination of figurative and word mark.",
                IPOPHLTrademark.Client.Shared.Enum.MarkType.ThreeD => "A three-dimensional representation used as a trademark.",
                IPOPHLTrademark.Client.Shared.Enum.MarkType.Collective => "A trademark owned by an organization used by its members to identify with a level of quality.",
                _ => ""
            };
        }
    }
}


