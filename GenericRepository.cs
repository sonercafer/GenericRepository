public class GenericRepository<TEntity> : IGenericRepository<TEntity>
            where TEntity : class, IEntity
    {
        private DbContext _dbContext;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        #region CRUD
        public IList<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(string rowid)
        {
            return _dbSet.Find(rowid);
        }

        public void Create(TEntity entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(string rowid, TEntity entity)
        {
            _dbSet.AddOrUpdate(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(string rowid)
        {
            var entity = _dbSet.Find(rowid);
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }
        #endregion
    }
