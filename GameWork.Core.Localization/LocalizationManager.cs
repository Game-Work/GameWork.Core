using System;
using System.Collections.Generic;

namespace GameWork.Core.Localization
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public class LocalizationManager
    {
        private LocalizationModel _model;
        private Dictionary<string, string> _currentLocalization;

        public event Action SetLocaleEvent;
        
        public void SetModel(LocalizationModel model)
        {
            _model = model;
            SetLocale(_model.Default);
        }

        public void SetLocale(string localeId)
        {
            _currentLocalization = _model.Localizations[localeId];

            SetLocaleEvent?.Invoke();
        }

        public string GetLocalization(string id)
        {
            string value = null;
            _currentLocalization?.TryGetValue(id, out value);

            return value;
        }

        public bool HasLocale(string locale)
        {
            return _model.Localizations.ContainsKey(locale);
        }

        public void Reset()
        {
            SetLocale(_model.Default);
        }
    }
}
