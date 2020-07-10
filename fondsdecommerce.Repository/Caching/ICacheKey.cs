namespace fondsdecommerce.Repository.Caching
{
    public interface ICacheKey<TItem>
    {
        string CacheKey { get; }
    }
}