
namespace Common_Objects_V2.Intake.Persistence
{
    public interface IIntakeRepository<T> where T : class, new()
    {
        IQueryable<T> GetAll();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
    }
}
