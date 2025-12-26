namespace blog_post_api.Repositery.Genric
{
    public interface IGenricRepo<T> where T : class
    {
        Task<T> add(T item);
        Task<T> remove(int id);
        Task<T> getById(int id);
        Task<T> update(T item);
        Task<IEnumerable<T>> getAll();
        void saveChanges();
    }
}
