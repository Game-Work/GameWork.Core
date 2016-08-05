using System.Collections.Generic;

namespace GameWork.Localization
{
    public class LocalizationManager
    {
        private LocalizationModel _model;
        private Dictionary<string, string> _currentLocalization;

        public void SetModel(LocalizationModel model)
        {
            _model = model;
        }

        public void SetLocale(string localeId)
        {
            _currentLocalization = _model.Localizations[localeId];
        }

        public string GetLocalization(string id)
        {
            return _currentLocalization[id];
        }

        public bool HasLocale(string locale)
        {
            return _model.Localizations.ContainsKey(locale);
        }
    }
}
