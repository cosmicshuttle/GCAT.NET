namespace GCAT.NET.Services
{
    /// <summary>
    /// CRUD interface for entity services
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEntityService<T>
    {
        public Task<T> Create(IEnumerable<T> items);
        
        public Task<T> Read(IEnumerable<string> codes);

        public Task<T> Update(IEnumerable<T> items);

        public Task<T> Delete(IEnumerable<T> items);
    }
}