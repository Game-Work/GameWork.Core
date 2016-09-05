using System.Collections.Generic;

namespace GameWork.IO
{
    public static class CSV
    {
        private const string Quote = "\"";
        private const string EscapedQuote = "\"\"";
        private static readonly char[] _charactersThatMustBeQuoted = { ',', '"', '\n'};
        private static readonly Dictionary<string, char> _escapedEscapeSequences = new Dictionary<string, char>
        {
            {"\\n", '\n'}
        };
        
        public static string Escape(string s)
        {
            if (s.Contains(Quote))
            {
                s = s.Replace(Quote, EscapedQuote);
            }

            if (s.IndexOfAny(_charactersThatMustBeQuoted) > -1)
            {
                s = Quote + s + Quote;
            }

            return s;
        }

        public static string Unescape(string s)
        {
            if (s.StartsWith(Quote) && s.EndsWith(Quote))
            {
                s = s.Substring(1, s.Length - 2);

                if (s.Contains(EscapedQuote))
                {
                    s = s.Replace(EscapedQuote, Quote);
                }
            }
            
            foreach(var escapedEscapeSequence in _escapedEscapeSequences.Keys)
            {
                s = s.Replace(escapedEscapeSequence, _escapedEscapeSequences[escapedEscapeSequence].ToString());
            }

            return s;
        }
    }
}
