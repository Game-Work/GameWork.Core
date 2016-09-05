using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace GameWork.IO
{
    public sealed class CSVReader : IDisposable
    {
        private static readonly Regex _rexCsvSplitter = new Regex(@",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))");
        private static readonly Regex _rexRunOnLine = new Regex(@"^[^""]*(?:""[^""]*""[^""]*)*""[^""]*$");

        private TextReader _reader;

        public CSVReader(string path) : this(new FileStream(path, FileMode.Open, FileAccess.Read))
        {
        }

        public CSVReader(Stream stream)
        {
            _reader = new StreamReader(stream);
        }

        public IEnumerable<string[]> RowEnumerator
        {
            get
            {
                var row = 0;
                string line;
                string nextLine;

                while ((line = _reader.ReadLine()) != null)
                {
                    while (_rexRunOnLine.IsMatch(line) && (nextLine = _reader.ReadLine()) != null)
                    {
                        line += "\n" + nextLine;
                    }

                    row++;

                    var values = _rexCsvSplitter.Split(line);

                    for (var i = 0; i < values.Length; i++)
                    {
                        values[i] = CSV.Unescape(values[i]);
                    }

                    yield return values;
                }
            }
        }

        public void Dispose()
        {
            if (_reader != null)
            {
                _reader.Dispose();
            }
        }
    }
}
