namespace Gestion_des_articles.Models.Repositories
{
    public interface IRepository<T>
    {
        T Get(int Id);
        IEnumerable<T> GetAll();
        T Add(T t);
        void Update(int id, T entity);
        T Delete(int Id);
        IEnumerable<T> Search(string term);
        Product Update(Product product);
    }
}
