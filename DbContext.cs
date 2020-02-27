    public class AkosContext : DbContext
    {
        public AkosContext() :base("ConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer<AkosContext>(null);
        }
        public DbSet<DATA_MODEL> MODEL_NAME { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        } 

    }
