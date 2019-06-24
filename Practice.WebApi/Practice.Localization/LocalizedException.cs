using System;

namespace Practice.Localization
{
    public class LocalizedException : Exception
    {
        public string MessageKey { get; }

        public object[] Parameters { get; set; }

        public LocalizedException(string key, params object[] parameters)
        {
            MessageKey = key;
            Parameters = parameters;
        }
    }
}
