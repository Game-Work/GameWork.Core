using System.Collections.Generic;
using GameWork.Interfaces.Models;

namespace GameWork.Localization
{
    public class LocalizationModel : IModel
    {
        public string Id { get; set; }

        public Dictionary<string, Dictionary<string, string>> Localizations { get; set; }
    }
}