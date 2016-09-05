using System.IO;
using GameWork.IO;
using System.Collections.Generic;

namespace GameWork.Localization
{
    public class LocalizationLoader
    {
        public LocalizationModel Load(Stream stream, string Id)
        {
            var model = new LocalizationModel();
            model.Id = Id;
            model.Localizations = new Dictionary<string, Dictionary<string, string>>();

            using (var reader = new CSVReader(stream))
            {
                string[] headers = new string[0];
                int row = 0;

                foreach (var rowValues in reader.RowEnumerator)
                {
                    if (row == 0)
                    {
                        headers = rowValues;
                        SetHeaders(model.Localizations, headers);
                    }
                    else
                    {
                        AddKeys(model.Localizations, headers, rowValues);
                    }

                    row++;
                }
            }

            return model;
        }

        private void SetHeaders(Dictionary<string, Dictionary<string, string>> localizationDictionary , string[] headers)
        {
            foreach (var header in headers)
            {
                localizationDictionary[header] = new Dictionary<string, string>();
            }
        }

        private void AddKeys(Dictionary<string, Dictionary<string, string>> localizationDictionary, string[] headers, string[] rowValues)
        {
            var key = rowValues[0];

            for (var col = 1; col < rowValues.Length; col++)
            {
                var header = headers[col];
                var value = rowValues[col];

                localizationDictionary[header].Add(key, value);
            }
        }
    }
}
