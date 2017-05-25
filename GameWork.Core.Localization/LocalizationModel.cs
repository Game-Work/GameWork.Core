using GameWork.Core.Models.Interfaces;
using System.Collections.Generic;

namespace GameWork.Core.Localization
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public struct LocalizationModel : IModel
    {
        public string Default { get; set; }

        public Dictionary<string, Dictionary<string, string>> Localizations { get; set; }
    }
}