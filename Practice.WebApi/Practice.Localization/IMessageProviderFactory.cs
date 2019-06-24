namespace Practice.Localization
{
    public interface IMessageProviderFactory
    {
        IMessageProvider GetProvider(Language language);
    }
}