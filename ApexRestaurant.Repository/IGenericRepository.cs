using System.Linq;
namespace ApexRestaurant.Repository
{
    public interface IGenericRepository<T>
    {
        T Get(int id);
        IQueryable<T> Query();

        void Insert(T entity);

        void update(T entity);

        void delete(T entity);

    }
}