    public interface IGenericRepository<TEntity>
        where TEntity : class
    {
        IList<TEntity> GetAll();

        TEntity GetById(string rowid);

        void Create(TEntity entity);

        void Update(string rowid, TEntity entity);

        void Delete(string rowid);
    }
