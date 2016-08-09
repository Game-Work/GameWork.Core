using System.Collections.Generic;
using GameWork.Common.Models.Interfaces;

namespace GameWork.Localization
{
    public class LocalizationModel : IModel
    {
        public string Id { get; set; }

        public Dictionary<string, Dictionary<string, string>> Localizations { get; set; }
    }
}