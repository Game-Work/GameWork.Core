using GameWork.Models.Interfaces;
using System.Collections.Generic;

namespace GameWork.Localization
{
    public struct LocalizationModel : IModel
    {
        public string Default { get; set; }

        public Dictionary<string, Dictionary<string, string>> Localizations { get; set; }
    }
}