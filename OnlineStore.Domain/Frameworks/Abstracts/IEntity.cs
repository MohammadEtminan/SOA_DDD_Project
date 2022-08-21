namespace OnlineStore.Domain.Frameworks.Abstracts
{
    public interface IEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
