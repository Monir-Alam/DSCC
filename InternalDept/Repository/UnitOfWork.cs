using InterDept.Data;
using InterDept.Repository.IRepository;

namespace InterDept.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }

        public ICategory Category { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
