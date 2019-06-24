namespace Practice.Localization
{
    public interface IMessageProvider
    {
        Language DefaultLanguage { get; set; }

        /// <summary>
        /// Get localized message with parameters for DefaultLanguage
        /// </summary>
        /// <param name="key">Message key</param>
        /// <param name="parameters">Message parameters</param>
        /// <returns></returns>
        string GetMessage(string key, params object[] parameters);

        string GetMessage(string key, Language language, params object[] parameters);
    }
}