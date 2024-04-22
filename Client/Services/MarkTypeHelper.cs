namespace IPOPHLTrademark.Client.Services
{
    public enum MarkType
    {
        None,
        Word,
        Figurative,
        FigurativeWithWord,
        ThreeD,
        Collective
    }

    public static class MarkTypeHelper
    {
        public static MarkType? selectedMarkType = null;

        public static void SelectMarkType(MarkType markType)
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

        public static string GetButtonClass(MarkType markType)
        {
            return selectedMarkType == markType ? "btn btn-dark" : "btn btn-light";
        }

        public static string GetMarkTypeImagePath(MarkType markType)
        {
            if (markType == MarkType.None)
            {
                return "";
            }

            string imageName = markType switch
            {
                MarkType.Word => "tm-wm.png",
                MarkType.Figurative => "tm-fm.png",
                MarkType.FigurativeWithWord => "tm-fwm.png",
                MarkType.ThreeD => "tm-dm.png",
                MarkType.Collective => "tm-cm.png",
                _ => ""
            };

            return $"regisForm-img/{imageName}";
        }

        public static string GetMarkTypeAltText(MarkType markType)
        {
            return markType == MarkType.None ? "" : markType.ToString();
        }

        public static string GetMarkTypeTitle(MarkType markType)
        {
            return markType switch
            {
                MarkType.Word => "Word Mark",
                MarkType.Figurative => "Figurative Mark",
                MarkType.FigurativeWithWord => "Figurative with Word Mark",
                MarkType.ThreeD => "3D Mark",
                MarkType.Collective => "Collective Mark",
                _ => ""
            };
        }

        public static string GetMarkTypeDescription(MarkType markType)
        {
            return markType switch
            {
                MarkType.Word => "A word mark consists solely of words, letters, or numbers without any design elements.",
                MarkType.Figurative => "A figurative mark includes designs, graphics, symbols, or images.",
                MarkType.FigurativeWithWord => "A combination of figurative and word mark.",
                MarkType.ThreeD => "A three-dimensional representation used as a trademark.",
                MarkType.Collective => "A trademark owned by an organization used by its members to identify with a level of quality.",
                _ => ""
            };
        }
    }
}


