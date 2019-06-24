using System.Collections.Generic;

namespace Practice.Localization
{
    public class MessageProviderFactory : IMessageProviderFactory
    {
        private Dictionary<Language, MessageProvider> _providers = new Dictionary<Language, MessageProvider>
        {
            { Language.Eng, new MessageProvider(Language.Eng) },
            { Language.Ru, new MessageProvider(Language.Ru) },
        };

        public IMessageProvider GetProvider(Language language)
        {
            return _providers[language];
        }
    }
}
