using System.Collections.Generic;
using GameWork.Models.Interfaces;

namespace GameWork.Localization
{
    public struct LocalizationModel : IModel
    {
        public string Id { get; set; }

        public string Default { get; set; }

        public Dictionary<string, Dictionary<string, string>> Localizations { get; set; }
    }
}