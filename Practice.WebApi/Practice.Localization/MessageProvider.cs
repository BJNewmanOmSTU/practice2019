using System.Collections.Generic;
using System.Resources;

namespace Practice.Localization
{
    public class MessageProvider : IMessageProvider
    {
        private static Dictionary<Language, ResourceManager> _resourseManagers;

        public Language DefaultLanguage { get; set; }

        static MessageProvider()
        {
            _resourseManagers = new Dictionary<Language, ResourceManager>
            {
                { Language.Eng, LocalizationEng.ResourceManager },
                { Language.Ru, LocalizationRu.ResourceManager },
            };
        }

        public MessageProvider(Language language)
        {
            this.DefaultLanguage = language;
        }

        public MessageProvider()
            : this(Language.Ru)
        {

        }

        /// <summary>
        /// Get localized message with parameters
        /// </summary>
        /// <param name="key">Message key</param>
        /// <param name="parameters">Message parameters</param>
        /// <returns></returns>
        public string GetMessage(string key, params object[] parameters)
        {
            var pattern = _resourseManagers[DefaultLanguage].GetString(key);
            if (pattern == null)
            {
                pattern = _resourseManagers[Language.Ru].GetString(key);
            }

            //Return key if localization is not found
            return pattern != null ? string.Format(pattern, parameters) : key;
        }

        /// <returns></returns>
        public string GetMessage(string key, Language language, params object[] parameters)
        {
            var pattern = _resourseManagers[language].GetString(key);
            return pattern != null ? string.Format(pattern, parameters) : null;
        }
    }
}
