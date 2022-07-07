namespace InterDept.Repository.IRepository
{
    public interface IUnitOfWork 
    {
        ICategory Category { get; }
        void Save();
    }
}
