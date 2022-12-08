namespace MSChildNotification.Persistence
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {

        protected readonly ChildNotificationDBContext _childNotificationDBContext;

        public Repository(ChildNotificationDBContext intakeDBContext)
        {
            _childNotificationDBContext = intakeDBContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                await _childNotificationDBContext.AddAsync(entity);
                await _childNotificationDBContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public IQueryable<T> GetAll()
        {
            try
            {
                return _childNotificationDBContext.Set<T>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                _childNotificationDBContext.Update(entity);
                await _childNotificationDBContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }
    }
}

